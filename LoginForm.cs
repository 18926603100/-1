using System.Windows.Forms;
using Sunny.UI;
using System.Data.SqlClient;

namespace 新悦管理系统
{
    public partial class LoginForm : UIForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }
    /*    /// <summary>
        /// 用户名按下框按回车，密码框获得焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiTextBox_name_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                uiTextBox_pwd.Focus(); //密码输入框获得焦点
            }

        }*/
        /// <summary>
        /// 如果要在密码框按下回车，自动点击login按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiTextBox_pwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                uiButton_login.PerformClick();//按下login按钮
            }
        }
      //点击login按钮
        private void uiButton_login_Click(object sender, System.EventArgs e)
        {
            UIMessageBox.Show("123456");
        }
    }
}
