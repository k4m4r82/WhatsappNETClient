using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using WhatsAppNETAPI;
using ConceptCave.WaitCursor;

namespace DemoWhatsAppNETAPICSharp
{
    public partial class FrmMain : Form
    {
        private IWhatsAppNETAPI _whatsAppApi;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _whatsAppApi = new WhatsAppNETAPI.WhatsAppNETAPI();

            var url = "https://web.whatsapp.com";

            using (new StCursor(Cursors.WaitCursor, new TimeSpan(0, 0, 0, 0)))
            {
                if (_whatsAppApi.Connect(url))
                {
                    while (!_whatsAppApi.OnReady())
                    {
                        Thread.Sleep(1000);
                    }

                    btnStart.Enabled = false;
                    btnStop.Enabled = true;
                    btnKirim.Enabled = true;

                    chkSubscribe.Enabled = true;
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _whatsAppApi.Disconnect();

            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnKirim.Enabled = false;

            chkSubscribe.Checked = false;
            chkSubscribe.Enabled = false;

            chkAutoReplay.Checked = false;
            chkAutoReplay.Enabled = false;

            lstPesanMasuk.Items.Clear();
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            var jumlahPesan = int.Parse(txtJumlahPesan.Text);

            if (jumlahPesan > 1)
            {
                var list = new List<BroadcastMsgArgs>();

                for (int i = 0; i < jumlahPesan; i++)
                {
                    list.Add(new BroadcastMsgArgs(txtKontak.Text, txtPesan.Text));
                }

                _whatsAppApi.BroadcastMessage(list, 1);
            }
            else
                _whatsAppApi.SendMessage(new MsgArgs(txtKontak.Text, txtPesan.Text));
        }

        private void chkSubscribe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSubscribe.Checked)
            {
                _whatsAppApi.OnMessageRecieved += OnMessageRecievedEventHandler;
                _whatsAppApi.MessageSubscribe();
            }
            else
            {
                _whatsAppApi.OnMessageRecieved -= OnMessageRecievedEventHandler;
                _whatsAppApi.MessageUnSubscribe();

                lstPesanMasuk.Items.Clear();
            }

            chkAutoReplay.Enabled = chkSubscribe.Checked;
        }

        private void chkAutoReplay_CheckedChanged(object sender, EventArgs e)
        {
            _whatsAppApi.AutoReplay = chkAutoReplay.Checked;
        }

        private void OnMessageRecievedEventHandler(MsgArgs e)
        {
            var msg = string.Format("[{0}] {1}: {2}",
                e.TimeStamp.ToString("yyyy-MM-dd HH:mm:ss"), e.Sender, e.Msg);

            // karena pesan yang masuk beda thread, 
            // jadi harus menggunakan cara seperti ini untuk mengupdate UI
            lstPesanMasuk.Invoke(() =>
            {
                lstPesanMasuk.Items.Add(msg);
                lstPesanMasuk.SelectedIndex = lstPesanMasuk.Items.Count - 1;
            });

            if (chkAutoReplay.Checked)
            {
                var msgReplay = string.Format("Bpk/Ibu *{0}*, perintah *{1}* sudah kami terima. Silahkan ditunggu.",
                    e.Sender, e.Msg);

                _whatsAppApi.SendMessageAutoReplay(new MsgArgs(e.Sender, msgReplay));
            }
        }
    }
}
