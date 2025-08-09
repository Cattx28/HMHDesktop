using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Apresentação
{
    public partial class FrmDashboard : Form
    {
        private WebView2 webView;

        private frmInicial parentForm;

        public FrmDashboard(frmInicial parent)
        {
            InitializeComponent();
            InitializeWebView();
            parentForm = parent;
        }

        public FrmDashboard()
        {
        }

        private async void InitializeWebView()
        {
            webView = new WebView2
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(webView);
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.Navigate("https://app.powerbi.com/view?r=eyJrIjoiMGFkMDg5YzEtMWNlNy00OTUwLWIxMTEtNzE0MjQ4MzVjMTMyIiwidCI6ImI0NzQxYTgyLTZiNmUtNDNhNS1hZDZlLTEwNDQ1MTFhYWVkNiJ9");
            //ttps://app.powerbi.com/reportEmbed?reportId=5221161c-c8f5-46e6-ae4d-4395b2f42671
            //ttps://app.powerbi.com/links/WlTl5dxI2w?ctid=d3acd233-2d54-401d-8cc3-d86d8614b7c5&pbi_source=linkShare
            //ttps://app.powerbi.com/reportEmbed?reportId=5221161c-c8f5-46e6-ae4d-4395b2f42671&autoAuth=true&ctid=d3acd233-2d54-401d-8cc3-d86d8614b7c5&actionBarEnabled=true&reportCopilotInEmbed=true
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        { 
        }
    }
}
