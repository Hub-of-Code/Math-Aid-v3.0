Public Class Form4
    Dim hj As Integer
    Dim x As Integer = 1
    Dim y As Integer
    Dim T As Integer = -1
    Dim A As Boolean
    Dim b As Boolean
    Dim c As Boolean
    Dim d As Boolean
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        MsgBox("", MsgBoxStyle.Information, "HELP AND INFO")
    End Sub
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        MsgBox("This software is a product of BTC CORP Community. Members of the team are; Edinyanga Ottoho (CEO), Victory Zibril (Program Manager) and Imikan Umoinyang (Software Informant)", MsgBoxStyle.Information, "ABOUT US")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListBox1.Items.Count >= 10 Or ComboBox1.Text = "" Or ListBox1.Items.Contains(ComboBox1.Text) Then
            MsgBox("Invalid!", MsgBoxStyle.Critical, "Error")
        Else : ListBox1.Items.Add(ComboBox1.Text)
            If ListBox1.Items.Count > 1 Then
                x = x + 1
                Dim la As New Label
                la.Name = "x" & x
                Dim ctl As Control
                For Each ctl In Controls
                    If TypeOf ctl Is Label Then
                        If ctl.Name = "x" & x - 1 Then
                            la.Location = New Point(ctl.Location.X, ctl.Location.Y + 19)
                            la.Text = ctl.Text
                            la.Size = ctl.Size
                            la.Font = ctl.Font
                            la.BackColor = ctl.BackColor
                            la.BringToFront()
                        End If
                    End If
                Next
                Me.Controls.Add(la)
                Dim lb As New TextBox
                lb.Name = "y" & x
                Dim ctx As Control
                For Each ctx In Controls
                    If TypeOf ctx Is TextBox Then
                        If ctx.Name = "y" & x - 1 Then
                            lb.Location = New Point(ctx.Location.X, ctx.Location.Y + 18)
                            lb.Multiline = True
                            lb.Size = ctx.Size
                            lb.Font = ctx.Font
                            lb.BringToFront()
                        End If
                    End If
                Next
                Me.Controls.Add(lb)
            End If
        End If
        PictureBox1.SendToBack()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            g.Items.Clear()
            Ng.Items.Clear()
            g.Text = "One"
            Ng.Text = " One"
            g.Items.Add("One")
            g.Items.Add("Two")
            g.Items.Add("Three")
            g.Items.Add("Four")
            g.Items.Add("Five")
            g.Items.Add("Six")
            Ng.Items.Add("One")
            Ng.Items.Add("Two")
            Ng.Items.Add("Three")
            Ng.Items.Add("Four")
            Ng.Items.Add("Five")
            Ng.Items.Add("Six")
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            g.Items.Clear()
            Ng.Items.Clear()
            g.Text = "Head"
            Ng.Text = " Head"
            g.Items.Add("Head")
            g.Items.Add("Tail")
            Ng.Items.Add("Head")
            Ng.Items.Add("Tail")
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub RadioButton1_Checkedchanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Label4.Text = "A Basket With Balls"
            ComboBox1.Text = "Red"
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Red")
            ComboBox1.Items.Add("Orange")
            ComboBox1.Items.Add("Yellow")
            ComboBox1.Items.Add("Green")
            ComboBox1.Items.Add("Blue")
            ComboBox1.Items.Add("Purple")
            ComboBox1.Items.Add("White")
            ComboBox1.Items.Add("Black")
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Label4.Text = "Students in a Class"
            ComboBox1.Text = "Boys"
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Boys")
            ComboBox1.Items.Add("Girls")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        y = 0
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                If ctl.Name.Contains("y") Then
                    y = y + Val(ctl.Text)
                    Label6.Text = "Total = " & y
                End If
            End If
        Next
        If RadioButton1.Checked = True Then
            Sel.Items.Clear()
            Sel.Items.Add("Red ball")
            Sel.Items.Add("Orange ball")
            Sel.Items.Add("Yellow ball")
            Sel.Items.Add("Green ball")
            Sel.Items.Add("Blue ball")
            Sel.Items.Add("Purple ball")
            Sel.Items.Add("White ball")
            Sel.Items.Add("Black ball")
            Sel.Text = "Red ball"
            NSel.Items.Clear()
            NSel.Items.Add("Red ball")
            NSel.Items.Add("Orange ball")
            NSel.Items.Add("Yellow ball")
            NSel.Items.Add("Green ball")
            NSel.Items.Add("Blue ball")
            NSel.Items.Add("Purple ball")
            NSel.Items.Add("White ball")
            NSel.Items.Add("Black ball")
            NSel.Text = "Red ball"
        End If
        If RadioButton2.Checked = True Then
            Sel.Items.Clear()
            Sel.Items.Add("Boy")
            Sel.Items.Add("Girl")
            Sel.Text = "Boy"
            NSel.Items.Clear()
            NSel.Items.Add("Boy")
            NSel.Items.Add("Girl")
            NSel.Text = "Boy"
        End If
    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged
        If A1.Checked = True Then
            A2.Checked = False
        End If
    End Sub

    Private Sub A2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A2.CheckedChanged
        If A2.Checked = True Then
            A1.Checked = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If A1.Checked = True Then
            If RadioButton1.Checked = True Then
                A = True
                Timer1.Enabled = True
                b = False
                c = False
                d = False
            End If
        End If
        If A2.Checked = True Then
            If RadioButton1.Checked = True Then
                b = True
                Timer1.Enabled = True
                A = False
                c = False
                d = False
            End If
        End If
        If A1.Checked = True Then
            If RadioButton2.Checked = True Then
                c = True
                Timer1.Enabled = True
                A = False
                b = False
                d = False
            End If
        End If
        If A2.Checked = True Then
            If RadioButton2.Checked = True Then
                d = True
                Timer1.Enabled = True
                A = False
                b = False
                c = False
            End If
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        T = T + 1
        If A = True Then
            If Sel.Text.Contains(ListBox1.Items(T)) Then
                Dim z As Integer = T + 1
                Dim ctl As Control
                For Each ctl In Controls
                    If TypeOf ctl Is TextBox Then
                        If ctl.Name = "y" & z Then
                            ListBox2.Items.Add("")
                            ListBox2.Items.Add("Probability = Number of Required Outcomes / Number of Possible Outcomes")
                            ListBox2.Items.Add("     Pr (Selecting a (an) " & Sel.Text & ")")
                            ListBox2.Items.Add("          = " & ctl.Text & " / " & y)
                            A = False
                            Timer1.Enabled = False
                        End If
                    End If
                Next
            End If
        End If
        If b = True Then
            If NSel.Text.Contains(ListBox1.Items(T)) Then
                Dim z As Integer = T + 1
                Dim ctl As Control
                For Each ctl In Controls
                    If TypeOf ctl Is TextBox Then
                        If ctl.Name = "y" & z Then
                            ListBox2.Items.Add("")
                            ListBox2.Items.Add("Probability = Number of Required Outcomes / Number of Possible Outcomes")
                            ListBox2.Items.Add("     Pr (Not Selecting a (an) " & NSel.Text & ")")
                            ListBox2.Items.Add("          = " & y - Val(ctl.Text) & " / " & y)
                            b = False
                            Timer1.Enabled = False
                        End If
                    End If
                Next
            End If
        End If
        If c = True Then
            If Sel.Text & "s" = ListBox1.Items(T) Then
                Dim z As Integer = T + 1
                Dim ctl As Control
                For Each ctl In Controls
                    If TypeOf ctl Is TextBox Then
                        If ctl.Name = "y" & z Then
                            ListBox2.Items.Add("")
                            ListBox2.Items.Add("Probability = Number of Required Outcomes / Number of Possible Outcomes")
                            ListBox2.Items.Add("     Pr (Selecting a (an) " & Sel.Text & ")")
                            ListBox2.Items.Add("          = " & ctl.Text & " / " & y)
                            c = False
                            Timer1.Enabled = False
                        End If
                    End If
                Next
            End If
        End If
        If d = True Then
            If NSel.Text & "s" = ListBox1.Items(T) Then
                Dim z As Integer = T + 1
                Dim ctl As Control
                For Each ctl In Controls
                    If TypeOf ctl Is TextBox Then
                        If ctl.Name = "y" & z Then
                            ListBox2.Items.Add("")
                            ListBox2.Items.Add("Probability = Number of Required Outcomes / Number of Possible Outcomes")
                            ListBox2.Items.Add("     Pr (Not Selecting a (an) " & NSel.Text & ")")
                            ListBox2.Items.Add("          = " & y - Val(ctl.Text) & " / " & y)
                            d = False
                            Timer1.Enabled = False
                        End If
                    End If
                Next
            End If
        End If
        If T = ListBox1.Items.Count - 1 Then
            A = False
            b = False
            c = False
            d = False
            T = -1
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub G1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1.CheckedChanged
        If G1.Checked = True Then
            G2.Checked = False
        End If
    End Sub

    Private Sub G2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G2.CheckedChanged
        If G2.Checked = True Then
            G1.Checked = False
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If G1.Checked = True Then
            If CheckBox1.Checked = True Then
                ListBox2.Items.Add("")
                ListBox2.Items.Add("")
                ListBox2.Items.Add("Probability = Number of Required Outcomes / Number of Possible Outcomes")
                ListBox2.Items.Add("     Pr (Getting a (an) " & g.Text & ")")
                ListBox2.Items.Add("          = 1/2")
            End If
        End If
        If G1.Checked = True Then
            If CheckBox2.Checked = True Then
                ListBox2.Items.Add("")
                ListBox2.Items.Add("")
                ListBox2.Items.Add("Probability = Number of Required Outcomes / Number of Possible Outcomes")
                ListBox2.Items.Add("     Pr (Getting a (an) " & g.Text & ")")
                ListBox2.Items.Add("          = 1/6")
            End If
        End If
        If G2.Checked = True Then
            If CheckBox1.Checked = True Then
                ListBox2.Items.Add("")
                ListBox2.Items.Add("")
                ListBox2.Items.Add("Probability = Number of Required Outcomes / Number of Possible Outcomes")
                ListBox2.Items.Add("     Pr (Not Getting a (an) " & g.Text & ")")
                ListBox2.Items.Add("          = 1/2")
            End If
        End If
        If G2.Checked = True Then
            If CheckBox2.Checked = True Then
                ListBox2.Items.Add("")
                ListBox2.Items.Add("")
                ListBox2.Items.Add("Probability = Number of Required Outcomes / Number of Possible Outcomes")
                ListBox2.Items.Add("     Pr (Not Getting a (an) " & g.Text & ")")
                ListBox2.Items.Add("          = 5/6")
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Timer2.Enabled = True
        y = 0
        Label6.Text = "Total = " & y
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        hj = hj + 1
        ListBox1.Items.Clear()
        x = 1
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                If ctl.Name.Contains("y") Then
                    If ctl.Name <> "y1" Then
                        Me.Controls.Remove(ctl)
                    End If
                End If
            End If
        Next
        Dim cty As Control
        For Each cty In Controls
            If TypeOf cty Is Label Then
                If cty.Name.Contains("x") Then
                    If cty.Name <> "x1" Then
                        Me.Controls.Remove(cty)
                    End If
                End If
            End If
        Next
        y1.Text = ""
        ListBox2.Items.Clear()
        If hj = 2 Then
            hj = 0
            Timer2.Enabled = False
        End If
        Dim ctb As Control
        For Each ctb In Controls
            If TypeOf ctb Is ComboBox Then
                ctb.Text = ""
            End If
        Next
        RadioButton4.Checked = True
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton4.Checked = True
    End Sub
End Class