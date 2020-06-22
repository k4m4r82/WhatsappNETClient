Imports System.Collections.Generic
Imports System.Threading

Imports WhatsAppNETAPI
Imports ConceptCave.WaitCursor

Public Class FrmMain

    Private _whatsAppApi As IWhatsAppNETAPI

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        _whatsAppApi = New WhatsAppNETAPI.WhatsAppNETAPI()

        Dim url = "https://web.whatsapp.com"

        Using New StCursor(Cursors.WaitCursor, New TimeSpan(0, 0, 0, 0))

            If (_whatsAppApi.Connect(url)) Then

                While (Not _whatsAppApi.OnReady())
                    Thread.Sleep(1000)
                End While

                btnStart.Enabled = False
                btnStop.Enabled = True
                btnKirim.Enabled = True

                chkSubscribe.Enabled = True
            End If

        End Using
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        _whatsAppApi.Disconnect()

        btnStart.Enabled = True
        btnStop.Enabled = False
        btnKirim.Enabled = False

        chkSubscribe.Checked = False
        chkSubscribe.Enabled = False

        chkAutoReplay.Checked = False
        chkAutoReplay.Enabled = False

        lstPesanMasuk.Items.Clear()
    End Sub

    Private Sub btnKirim_Click(sender As Object, e As EventArgs) Handles btnKirim.Click
        Dim jumlahPesan = Integer.Parse(txtJumlahPesan.Text)

        If (jumlahPesan > 1) Then            
            Dim list = New List(Of BroadcastMsgArgs)

            For index = 1 To jumlahPesan
                list.Add(New BroadcastMsgArgs(txtKontak.Text, txtPesan.Text))
            Next

            _whatsAppApi.BroadcastMessage(list, 1)
        Else
            _whatsAppApi.SendMessage(New MsgArgs(txtKontak.Text, txtPesan.Text))
        End If
    End Sub

    Private Sub chkSubscribe_CheckedChanged(sender As Object, e As EventArgs) Handles chkSubscribe.CheckedChanged

        If (chkSubscribe.Checked) Then
            AddHandler _whatsAppApi.OnMessageRecieved, AddressOf OnMessageRecievedEventHandler
            _whatsAppApi.MessageSubscribe()
        Else
            RemoveHandler _whatsAppApi.OnMessageRecieved, AddressOf OnMessageRecievedEventHandler
            _whatsAppApi.MessageUnSubscribe()

            lstPesanMasuk.Items.Clear()
            chkAutoReplay.Checked = False
        End If

        chkAutoReplay.Enabled = chkSubscribe.Checked
    End Sub

    Private Sub chkAutoReplay_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutoReplay.CheckedChanged
        _whatsAppApi.AutoReplay = chkAutoReplay.Checked
    End Sub

    Private Sub OnMessageRecievedEventHandler(e As MsgArgs)
        Dim msg = String.Format("[{0}] {1}: {2}",
                e.TimeStamp.ToString("yyyy-MM-dd HH:mm:ss"), e.Sender, e.Msg)

        ' karena pesan yang masuk beda thread, 
        ' jadi harus menggunakan cara seperti ini untuk mengupdate UI
        lstPesanMasuk.Invoke(
            Sub()
                lstPesanMasuk.Items.Add(msg)
                lstPesanMasuk.SelectedIndex = lstPesanMasuk.Items.Count - 1
            End Sub
        )

        If (chkAutoReplay.Checked) Then

            Dim msgReplay = String.Format("Bpk/Ibu *{0}*, perintah *{1}* sudah kami terima. Silahkan ditunggu.",
                    e.Sender, e.Msg)

            _whatsAppApi.SendMessageAutoReplay(New MsgArgs(e.Sender, msgReplay))

        End If
    End Sub
End Class
