Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label92.Left < Me.Width Then
            Label92.Left += 9
        Else
            Label92.Left = -Label92.Width
        End If
    End Sub

    Private Sub الصفحهالرئيسيةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles الصفحهالرئيسيةToolStripMenuItem.Click
        Panel1.BringToFront()
    End Sub

    Private Sub تيشيرتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تيشيرتToolStripMenuItem.Click
        Panel2.BringToFront()
    End Sub

    Private Sub قمصانToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles قمصانToolStripMenuItem.Click
        Panel3.BringToFront()
    End Sub

    Private Sub بناطيلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles بناطيلToolStripMenuItem.Click
        Panel4.BringToFront()
    End Sub

    Private Sub ستراتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ستراتToolStripMenuItem.Click
        Panel5.BringToFront()
    End Sub

    Private Sub معاطفToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles معاطفToolStripMenuItem.Click
        Panel6.BringToFront()
    End Sub

    Private Sub احزمةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles احزمةToolStripMenuItem.Click
        Panel7.BringToFront()
    End Sub

    Private Sub قبعاتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles قبعاتToolStripMenuItem.Click
        Panel8.BringToFront()
    End Sub

    Private Sub ربطاتالعنقToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ربطاتالعنقToolStripMenuItem.Click
        Panel9.BringToFront()
    End Sub

    Private Sub رياضيةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles رياضيةToolStripMenuItem.Click
        Panel10.BringToFront()
    End Sub

    Private Sub رسميToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles رسميToolStripMenuItem.Click
        Panel11.BringToFront()
    End Sub

    Private Sub كاجولToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles كاجولToolStripMenuItem.Click
        Panel12.BringToFront()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox10.Visible = True
        TextBox10.Text = Val(TextBox1.Text) + Val(TextBox11.Text) + Val(TextBox18.Text) + Val(TextBox16.Text) + Val(TextBox17.Text) + Val(TextBox20.Text) + Val(TextBox19.Text) + Val(TextBox21.Text) + Val(TextBox14.Text) + Val(TextBox2.Text)
        Button4.Visible = True

    End Sub

    Private Sub LinkLabel24_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel24.LinkClicked
        PictureBox68.Visible = True
        PictureBox68.Image = PictureBox60.Image

        TextBox1.Visible = True
        TextBox1.Text = Label60.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel23_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel23.LinkClicked
        PictureBox68.Visible = True
        PictureBox68.Image = PictureBox59.Image

        TextBox1.Visible = True
        TextBox1.Text = Label59.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel22_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel22.LinkClicked
        PictureBox68.Visible = True
        PictureBox68.Image = PictureBox58.Image

        TextBox1.Visible = True
        TextBox1.Text = Label58.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel21_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel21.LinkClicked
        PictureBox68.Visible = True
        PictureBox68.Image = PictureBox57.Image

        TextBox1.Visible = True
        TextBox1.Text = Label57.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel20_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel20.LinkClicked
        PictureBox68.Visible = True
        PictureBox68.Image = PictureBox56.Image

        TextBox1.Visible = True
        TextBox1.Text = Label56.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel19_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel19.LinkClicked
        PictureBox68.Visible = True
        PictureBox68.Image = PictureBox55.Image

        TextBox1.Visible = True
        TextBox1.Text = Label55.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        PictureBox126.Visible = True
        PictureBox126.Image = PictureBox6.Image

        TextBox11.Visible = True
        TextBox11.Text = Label6.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        PictureBox126.Visible = True
        PictureBox126.Image = PictureBox5.Image

        TextBox11.Visible = True
        TextBox11.Text = Label5.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        PictureBox126.Visible = True
        PictureBox126.Image = PictureBox4.Image

        TextBox11.Visible = True
        TextBox11.Text = Label4.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        PictureBox126.Visible = True
        PictureBox126.Image = PictureBox3.Image

        TextBox11.Visible = True
        TextBox11.Text = Label3.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        PictureBox126.Visible = True
        PictureBox126.Image = PictureBox2.Image

        TextBox11.Visible = True
        TextBox11.Text = Label2.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        PictureBox126.Visible = True
        PictureBox126.Image = PictureBox1.Image

        TextBox11.Visible = True
        TextBox11.Text = Label1.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel12_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel12.LinkClicked
        PictureBox70.Visible = True
        PictureBox70.Image = PictureBox12.Image

        TextBox18.Visible = True
        TextBox18.Text = Label12.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel11_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked
        PictureBox70.Visible = True
        PictureBox70.Image = PictureBox11.Image

        TextBox18.Visible = True
        TextBox18.Text = Label11.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel10_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        PictureBox70.Visible = True
        PictureBox70.Image = PictureBox10.Image

        TextBox18.Visible = True
        TextBox18.Text = Label10.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel9_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        PictureBox70.Visible = True
        PictureBox70.Image = PictureBox9.Image

        TextBox18.Visible = True
        TextBox18.Text = Label9.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        PictureBox70.Visible = True
        PictureBox70.Image = PictureBox8.Image

        TextBox18.Visible = True
        TextBox18.Text = Label8.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        PictureBox70.Visible = True
        PictureBox70.Image = PictureBox7.Image

        TextBox18.Visible = True
        TextBox18.Text = Label7.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel18_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel18.LinkClicked
        PictureBox69.Visible = True
        PictureBox69.Image = PictureBox18.Image

        TextBox16.Visible = True
        TextBox16.Text = Label18.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel17_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel17.LinkClicked
        PictureBox69.Visible = True
        PictureBox69.Image = PictureBox17.Image

        TextBox16.Visible = True
        TextBox16.Text = Label17.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel16_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel16.LinkClicked
        PictureBox69.Visible = True
        PictureBox69.Image = PictureBox16.Image

        TextBox16.Visible = True
        TextBox16.Text = Label16.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel15_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel15.LinkClicked
        PictureBox69.Visible = True
        PictureBox69.Image = PictureBox15.Image

        TextBox16.Visible = True
        TextBox16.Text = Label15.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel14_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel14.LinkClicked
        PictureBox69.Visible = True
        PictureBox69.Image = PictureBox14.Image

        TextBox16.Visible = True
        TextBox16.Text = Label14.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel13_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel13.LinkClicked
        PictureBox69.Visible = True
        PictureBox69.Image = PictureBox13.Image

        TextBox16.Visible = True
        TextBox16.Text = Label13.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel30_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel30.LinkClicked
        PictureBox71.Visible = True
        PictureBox71.Image = PictureBox24.Image

        TextBox17.Visible = True
        TextBox17.Text = Label24.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel29_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel29.LinkClicked
        PictureBox71.Visible = True
        PictureBox71.Image = PictureBox23.Image

        TextBox17.Visible = True
        TextBox17.Text = Label23.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel28_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel28.LinkClicked
        PictureBox71.Visible = True
        PictureBox71.Image = PictureBox22.Image

        TextBox17.Visible = True
        TextBox17.Text = Label22.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel27_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel27.LinkClicked
        PictureBox71.Visible = True
        PictureBox71.Image = PictureBox21.Image

        TextBox17.Visible = True
        TextBox17.Text = Label21.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel26_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel26.LinkClicked
        PictureBox71.Visible = True
        PictureBox71.Image = PictureBox20.Image

        TextBox17.Visible = True
        TextBox17.Text = Label20.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel25_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel25.LinkClicked
        PictureBox71.Visible = True
        PictureBox71.Image = PictureBox19.Image

        TextBox17.Visible = True
        TextBox17.Text = Label19.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel66_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel66.LinkClicked
        PictureBox80.Visible = True
        PictureBox80.Image = PictureBox66.Image

        TextBox20.Visible = True
        TextBox20.Text = Label66.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel65_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel65.LinkClicked
        PictureBox80.Visible = True
        PictureBox80.Image = PictureBox65.Image

        TextBox20.Visible = True
        TextBox20.Text = Label65.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel64_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel64.LinkClicked
        PictureBox80.Visible = True
        PictureBox80.Image = PictureBox64.Image

        TextBox20.Visible = True
        TextBox20.Text = Label64.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel63_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel63.LinkClicked
        PictureBox80.Visible = True
        PictureBox80.Image = PictureBox63.Image

        TextBox20.Visible = True
        TextBox20.Text = Label63.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel62_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel62.LinkClicked
        PictureBox80.Visible = True
        PictureBox80.Image = PictureBox62.Image

        TextBox20.Visible = True
        TextBox20.Text = Label62.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel61_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel61.LinkClicked
        PictureBox80.Visible = True
        PictureBox80.Image = PictureBox61.Image

        TextBox20.Visible = True
        TextBox20.Text = Label61.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel36_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel36.LinkClicked
        PictureBox72.Visible = True
        PictureBox72.Image = PictureBox30.Image

        TextBox19.Visible = True
        TextBox19.Text = Label30.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel35_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel35.LinkClicked
        PictureBox72.Visible = True
        PictureBox72.Image = PictureBox29.Image

        TextBox19.Visible = True
        TextBox19.Text = Label29.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel34_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel34.LinkClicked
        PictureBox72.Visible = True
        PictureBox72.Image = PictureBox28.Image

        TextBox19.Visible = True
        TextBox19.Text = Label28.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel33_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel33.LinkClicked
        PictureBox72.Visible = True
        PictureBox72.Image = PictureBox27.Image

        TextBox19.Visible = True
        TextBox19.Text = Label27.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel32_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel32.LinkClicked
        PictureBox72.Visible = True
        PictureBox72.Image = PictureBox26.Image

        TextBox19.Visible = True
        TextBox19.Text = Label26.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel31_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel31.LinkClicked
        PictureBox72.Visible = True
        PictureBox72.Image = PictureBox25.Image

        TextBox19.Visible = True
        TextBox19.Text = Label25.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel42_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel42.LinkClicked
        PictureBox79.Visible = True
        PictureBox79.Image = PictureBox36.Image

        TextBox21.Visible = True
        TextBox21.Text = Label36.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel41_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel41.LinkClicked
        PictureBox79.Visible = True
        PictureBox79.Image = PictureBox35.Image

        TextBox21.Visible = True
        TextBox21.Text = Label35.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel40_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel40.LinkClicked
        PictureBox79.Visible = True
        PictureBox79.Image = PictureBox34.Image

        TextBox21.Visible = True
        TextBox21.Text = Label34.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel39_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel39.LinkClicked
        PictureBox79.Visible = True
        PictureBox79.Image = PictureBox33.Image

        TextBox21.Visible = True
        TextBox21.Text = Label33.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel38_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel38.LinkClicked
        PictureBox79.Visible = True
        PictureBox79.Image = PictureBox32.Image

        TextBox21.Visible = True
        TextBox21.Text = Label32.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel37_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel37.LinkClicked
        PictureBox79.Visible = True
        PictureBox79.Image = PictureBox31.Image

        TextBox21.Visible = True
        TextBox21.Text = Label31.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel48_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel48.LinkClicked
        PictureBox121.Visible = True
        PictureBox121.Image = PictureBox42.Image

        TextBox14.Visible = True
        TextBox14.Text = Label42.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel47_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel47.LinkClicked
        PictureBox121.Visible = True
        PictureBox121.Image = PictureBox41.Image

        TextBox14.Visible = True
        TextBox14.Text = Label41.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel46_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel46.LinkClicked
        PictureBox121.Visible = True
        PictureBox121.Image = PictureBox40.Image

        TextBox14.Visible = True
        TextBox14.Text = Label40.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel45_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel45.LinkClicked
        PictureBox121.Visible = True
        PictureBox121.Image = PictureBox39.Image

        TextBox14.Visible = True
        TextBox14.Text = Label39.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel44_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel44.LinkClicked
        PictureBox121.Visible = True
        PictureBox121.Image = PictureBox38.Image

        TextBox14.Visible = True
        TextBox14.Text = Label38.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel43_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel43.LinkClicked
        PictureBox121.Visible = True
        PictureBox121.Image = PictureBox37.Image

        TextBox14.Visible = True
        TextBox14.Text = Label37.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel54_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel54.LinkClicked
        PictureBox67.Visible = True
        PictureBox67.Image = PictureBox48.Image

        TextBox2.Visible = True
        TextBox2.Text = Label48.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel53_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel53.LinkClicked
        PictureBox67.Visible = True
        PictureBox67.Image = PictureBox47.Image

        TextBox2.Visible = True
        TextBox2.Text = Label47.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel52_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel52.LinkClicked
        PictureBox67.Visible = True
        PictureBox67.Image = PictureBox46.Image

        TextBox2.Visible = True
        TextBox2.Text = Label46.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel51_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel51.LinkClicked
        PictureBox67.Visible = True
        PictureBox67.Image = PictureBox45.Image

        TextBox2.Visible = True
        TextBox2.Text = Label45.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel50_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel50.LinkClicked
        PictureBox67.Visible = True
        PictureBox67.Image = PictureBox44.Image

        TextBox2.Visible = True
        TextBox2.Text = Label44.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel49_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel49.LinkClicked
        PictureBox67.Visible = True
        PictureBox67.Image = PictureBox43.Image

        TextBox2.Visible = True
        TextBox2.Text = Label43.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel60_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel60.LinkClicked
        PictureBox67.Visible = True
        PictureBox67.Image = PictureBox54.Image

        TextBox2.Visible = True
        TextBox2.Text = Label54.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel59_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel59.LinkClicked
        PictureBox67.Visible = True
        PictureBox67.Image = PictureBox53.Image

        TextBox2.Visible = True
        TextBox2.Text = Label53.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel58_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel58.LinkClicked
        PictureBox67.Visible = True
        PictureBox67.Image = PictureBox52.Image

        TextBox2.Visible = True
        TextBox2.Text = Label52.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel57_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel57.LinkClicked
        PictureBox67.Visible = True
        PictureBox67.Image = PictureBox51.Image

        TextBox2.Visible = True
        TextBox2.Text = Label51.Text
        Button3.Visible = True
    End Sub

    Private Sub GroupBox50_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox50.Enter

    End Sub

    Private Sub LinkLabel56_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel56.LinkClicked
        PictureBox67.Visible = True
        PictureBox67.Image = PictureBox50.Image

        TextBox2.Visible = True
        TextBox2.Text = Label50.Text
        Button3.Visible = True
    End Sub

    Private Sub LinkLabel55_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel55.LinkClicked
        PictureBox67.Visible = True
        PictureBox67.Image = PictureBox49.Image

        TextBox2.Visible = True
        TextBox2.Text = Label49.Text
        Button3.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel3.BringToFront()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Panel10.BringToFront()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Panel6.BringToFront()
    End Sub

    Private Sub مركزالدعمToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مركزالدعمToolStripMenuItem.Click
        Panel13.BringToFront()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TextBox3.Text = "" And TextBox4.Text = "" And TextBox5.Text = "" Then
            MessageBox.Show("اكمل متطلبات الادخال ؟")
        Else
            MessageBox.Show("تم الدفع بنجاح ,شكرا لختيارك موقعنا ")
            Panel1.BringToFront()
        End If
    End Sub

    Private Sub مركزالدعمToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مركزالدعمToolStripMenuItem1.Click
        Panel15.BringToFront()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Panel14.BringToFront()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If BunifuMetroTextbox1.Text = "" And BunifuMetroTextbox2.Text = "" And BunifuMetroTextbox3.Text = "" Then
            MessageBox.Show("اكمل متطلبات الادخال ؟")
        Else
            MessageBox.Show("تم الارسال")
            Panel1.BringToFront()
        End If
    End Sub
End Class
