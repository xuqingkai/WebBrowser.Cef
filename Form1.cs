using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.Cef
{
    public partial class Form1 : Form
    {
        CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser;
        public Form1()
        {
            InitializeComponent();

            string address = "https://xuqingkai.github.io/my.element/";
            address = "https://xuqingkai.gitee.io/peis.web/";

            CefSharp.CefSettings cefSettings = new CefSharp.CefSettings();
            cefSettings.CefCommandLineArgs.Add("--disable-web-security", "1");//关闭同源策略,允许跨域
            cefSettings.CefCommandLineArgs.Add("--disable-site-isolation-trials", "1");//关闭站点隔离策略,允许跨域

            CefSharp.Cef.Initialize(cefSettings);
            chromiumWebBrowser = new CefSharp.WinForms.ChromiumWebBrowser(address);
            chromiumWebBrowser.Dock = DockStyle.Fill;

            chromiumWebBrowser.RegisterJsObject("external", new JsObject());
            chromiumWebBrowser.FrameLoadEnd += ChromiumWebBrowser_FrameLoadEnd;
            chromiumWebBrowser.KeyboardHandler = new CEFKeyBoardHander();

            this.splitContainer1.Panel2.Controls.Add(chromiumWebBrowser);
        }
        private void ChromiumWebBrowser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            //chromiumWebBrowser.ExecuteScriptAsync("CefSharp.BindObjectAsync('external');");
            //string js = System.IO.File.ReadAllText(System.Windows.Forms.Application.StartupPath + "./jquery.min.js");

            string function = "(function(){for(var key in window.external){window.alert(key);}})();";
            chromiumWebBrowser.ExecuteScriptAsync(function);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            //chromiumWebBrowser.ExecuteScriptAsync("swipeIDCard('{\"name\":\"cef\"}');");

            Task<CefSharp.JavascriptResponse> task = chromiumWebBrowser.GetBrowser().MainFrame.EvaluateScriptAsync("swipeIDCard('{\"name\":\"cef\"}');");
            task.Wait();
            if (task.Result.Result != null)
            {
                MessageBox.Show("js return：" + task.Result.Result.ToString());
            }
        }
    }
    public class JsObject
    {
        public string msgText = "msg";
        public void test()
        {
            MessageBox.Show("this in C#");
        }
        public void swipeIDCard(object obj) {
            MessageBox.Show("JsObject：" + obj.ToString());
        }
    }
    public class CEFKeyBoardHander : IKeyboardHandler
    {
        public bool OnKeyEvent(IWebBrowser browserControl, IBrowser browser, KeyType type, int windowsKeyCode, int nativeKeyCode, CefEventFlags modifiers, bool isSystemKey)
        {
            if (type == KeyType.KeyUp && Enum.IsDefined(typeof(Keys), windowsKeyCode))
            {
                var key = (Keys)windowsKeyCode;
                switch (key)
                {
                    case Keys.F12:
                        browser.ShowDevTools();
                        break;

                    case Keys.F5:

                        if (modifiers == CefEventFlags.ControlDown)
                        {
                            //MessageBox.Show("ctrl+f5");
                            browser.Reload(true); //强制忽略缓存

                        }
                        else
                        {
                            //MessageBox.Show("f5");
                            browser.Reload();
                        }
                        break;


                }
            }
            return false;
        }

        public bool OnPreKeyEvent(IWebBrowser browserControl, IBrowser browser, KeyType type, int windowsKeyCode, int nativeKeyCode, CefEventFlags modifiers, bool isSystemKey, ref bool isKeyboardShortcut)
        {
            return false;
        }
    }
}
