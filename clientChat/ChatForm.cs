using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clientChat
{
    public partial class ChatForm : Form, ChatService.IChatServiceCallback
    {
        bool IsConnected = false;
        ChatService.ChatServiceClient Client;
        int ID;
        LoginForm loginForm;
        
        //скругление формы
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
        );
        public ChatForm(string name, LoginForm lg)
        {
            InitializeComponent();

            //скругление формы
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            loginForm = lg;

            UserBox.Text = name;
            UserBox.Enabled = false;
            ConnectUser();
        }
        public void ChangeUser(string name)
        {
            UserBox.Text = name;
            ConnectUser();
        }
        void ConnectUser()
        {
            if (!IsConnected)
            {
                Client = new ChatService.ChatServiceClient(new System.ServiceModel.InstanceContext(this));

                ID = Client.Connect(UserBox.Text.ToString());

                //UserBox.Enabled = false;
                //buttonEnter.Text = "Отключиться";
                IsConnected = true;
            }
        }
        void DisconnectUser()
        {
            if (IsConnected)
            {
                Client.Disconnect(ID);
                
                //UserBox.Enabled = true;
                //buttonEnter.Text = "Подключиться";
                IsConnected = false;

                this.Hide();
                loginForm.Show();
            }
        }
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if(IsConnected) DisconnectUser();
            else ConnectUser();
        }

        public void MessageCallback(string msg)
        {
            chatBox.Items.Add(msg);
        }
        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectUser();
            loginForm.Close();
        }

        private void msgBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(Client != null)
                {
                    Client.SendMessage(msgBox.Text.ToString(), ID);
                    msgBox.Clear();
                }
            }
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
    }
}
