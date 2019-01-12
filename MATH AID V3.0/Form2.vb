Public Class Form2
    Dim x As Integer
    Dim y As Integer
    Dim z As Integer
    Dim o As String
    Dim k As String

    Dim xx As Integer
    Dim yy As Integer
    Dim z1 As String
    Dim z2 As String
    Dim t As Integer
    Dim oo As String
    Dim bb As String
    Dim nn As Integer
    Dim pp As Integer

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        MsgBox("Input the digits in the appropriate boxes and Click on the Solve button. The Clear button clears the inputs. The left Hand side if for conversion from Base 10 to other bases and the Right is for conversion of base other bases to base 10", MsgBoxStyle.Information, "HELP AND INFO")
    End Sub
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        MsgBox("This software is a product of BTC CORP Community. Members of the team are; Edinyanga Ottoho (CEO), Victory Zibril (Program Manager) and Imikan Umoinyang (Software Informant)", MsgBoxStyle.Information, "ABOUT US")
    End Sub
    Private Sub CALC_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CALC.Tick
        If x = 0 Then
            x = Val(ComboBox1.Text)
        End If
        If y = 0 Then
            y = Val(TextBox4.Text)
        End If
        y = CStr(Math.DivRem(y, x, z))
        If y = 0 Then
            Timer1.Enabled = True
            CALC.Enabled = False
        End If
        ListBox1.Items.Add(x)
        ListBox2.Items.Add(y)
        ListBox3.Items.Add(z)
        ListBox4.Items.Add(z)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        TextBox1.Text = ComboBox1.Text
        TextBox2.Text = TextBox4.Text
        CALC.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        o = ""
        x = 0
        y = 0
        z = 0
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = "REM"
        TextBox4.Text = ""
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        k = ""
        ComboBox1.Text = "2"
        Label5.Text = ""

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim a As Integer
        Dim b As String
        Do
            a = ListBox4.Items.Count - 1
            b = ListBox4.Items(a)
            If b <> "10" Or b <> "11" Or b <> "12" Or b <> "13" Or b <> "14" Or b <> "15" Then
                ListBox5.Items.Add(b)
                k += b
                ListBox4.Items.RemoveAt(a)
            End If
            If b = "10" Then
                ListBox5.Items.Add("A")
                k += "A"
                k = k.Replace("10", "")
            End If
            If b = "11" Then
                ListBox5.Items.Add("B")
                k += "B"
                k = k.Replace("11", "")
            End If
            If b = "12" Then
                ListBox5.Items.Add("C")
                k += "C"
                k = k.Replace("12", "")
            End If
            If b = "13" Then
                ListBox5.Items.Add("D")
                k += "D"
                k = k.Replace("13", "")
            End If
            If b = "14" Then
                ListBox5.Items.Add("E")
                k += "E"
                k = k.Replace("14", "")
            End If
            If b = "15" Then
                ListBox5.Items.Add("F")
                k += "F"
                k = k.Replace("15", "")
            End If
        Loop Until a = 0
        Label5.Text = "Therefore; " & TextBox4.Text & " in Base 10 = " & k & " in base " & ComboBox1.Text
        Timer1.Enabled = False

    End Sub
    Private Sub ComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged
        If Val(ComboBox1.Text) > 16 Then
            MsgBox("You can only enter digits between 2 and 9 with digit 16")
            ComboBox1.Text = "2"
        End If
    End Sub

    Private Sub ComboBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles B.TextChanged
        If Val(B.Text) > 16 Then
            MsgBox("You can only enter digits between 2 and 9 with digit 16")
            B.Text = "2"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        z1 = BC.Text
        z2 = B.Text
        xx = z1.Count
        yy = -1
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        xx = xx - 1
        yy = yy + 1
        If z1(yy) = "A" Then
            RichTextBox1.Text += " + 10" & " * (" & z2 & "^" & xx & ")"
            t = 10 * (Val(z2) ^ Val(xx))
            oo += " + " & t
            ListBox7.Items.Add(10 * (Val(z2) ^ Val(xx)))
        End If
        If z1(yy) = "B" Then
            RichTextBox1.Text += " + 11" & " * (" & z2 & "^" & xx & ")"
            t = 11 * (Val(z2) ^ Val(xx))
            oo += " + " & t
            ListBox7.Items.Add(11 * (Val(z2) ^ Val(xx)))
        End If
        If z1(yy) = "C" Then
            RichTextBox1.Text += " + 12" & " * (" & z2 & "^" & xx & ")"
            t = 12 * (Val(z2) ^ Val(xx))
            oo += " + " & t
            ListBox7.Items.Add(12 * (Val(z2) ^ Val(xx)))
        End If
        If z1(yy) = "D" Then
            RichTextBox1.Text += " + 13" & " * (" & z2 & "^" & xx & ")"
            t = 13 * (Val(z2) ^ Val(xx))
            oo += " + " & t
            ListBox7.Items.Add(13 * (Val(z2) ^ Val(xx)))
        End If
        If z1(yy) = "E" Then
            RichTextBox1.Text += " + 14" & " * (" & z2 & "^" & xx & ")"
            t = 14 * (Val(z2) ^ Val(xx))
            oo += " + " & t
            ListBox7.Items.Add(14 * (Val(z2) ^ Val(xx)))
        End If
        If z1(yy) = "F" Then
            RichTextBox1.Text += " + 15" & " * (" & z2 & "^" & xx & ")"
            t = 15 * (Val(z2) ^ Val(xx))
            oo += " + " & t
            ListBox7.Items.Add(15 * (Val(z2) ^ Val(xx)))
        End If
        If z1(yy) <> "A" Then
            If z1(yy) <> "B" Then
                If z1(yy) <> "C" Then
                    If z1(yy) <> "D" Then
                        If z1(yy) <> "E" Then
                            If z1(yy) <> "F" Then
                                RichTextBox1.Text += " + " & z1(yy) & " * (" & z2 & "^" & xx & ")"
                                t = Val(z1(yy)) * (Val(z2) ^ Val(xx))
                                oo += " + " & t
                                ListBox7.Items.Add(Val(z1(yy)) * (Val(z2) ^ Val(xx)))
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If xx = -1 Then
            Timer3.Enabled = True
            Timer2.Enabled = False
        End If
        If yy = z1.Count - 1 Then
            Timer3.Enabled = True
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        RichTextBox1.Text = RichTextBox1.Text.Remove(0, 3)
        oo = oo.Remove(0, 2)
        ListBox6.Items.Add(BC.Text & (" = ") & RichTextBox1.Text)
        ListBox6.Items.Add(("    = ") & oo)
        For Me.nn = 0 To ListBox7.Items.Count - 1
            pp = pp + Val(ListBox7.Items(nn))
        Next nn
        ListBox6.Items.Add("    =  " & pp)
        ListBox6.Items.Add("Therefore; " & BC.Text & " in Base " & B.Text & " to Base 10 = " & pp)
        Timer3.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        oo = ""
        nn = 0
        xx = 0
        pp = 0
        yy = 0
        z1 = ""
        z2 = ""
        bb = ""
        t = 0
        BC.Text = ""
        B.Text = "2"
        RichTextBox1.Text = ""
        ListBox7.Items.Clear()
        ListBox6.Items.Clear()
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
    End Sub

    Private Sub BC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BC.TextChanged
        If B.Text = "2" Then
            If BC.Text.Contains("2") Or BC.Text.Contains("3") Or BC.Text.Contains("4") Or BC.Text.Contains("5") Or BC.Text.Contains("6") Or BC.Text.Contains("7") Or BC.Text.Contains("8") Or BC.Text.Contains("9") Or BC.Text.Contains("A") Or BC.Text.Contains("B") Or BC.Text.Contains("C") Or BC.Text.Contains("D") Or BC.Text.Contains("E") Or BC.Text.Contains("F") Then
                MsgBox("That is not a number in this base")
                BC.Text = ""
            End If
        End If
        If B.Text = "3" Then

            If BC.Text.Contains("3") Or BC.Text.Contains("4") Or BC.Text.Contains("5") Or BC.Text.Contains("6") Or BC.Text.Contains("7") Or BC.Text.Contains("8") Or BC.Text.Contains("9") Or BC.Text.Contains("A") Or BC.Text.Contains("B") Or BC.Text.Contains("C") Or BC.Text.Contains("D") Or BC.Text.Contains("E") Or BC.Text.Contains("F") Then
                MsgBox("That is not a number in this base")
                BC.Text = ""
            End If
        End If
        If B.Text = "4" Then

            If ("4") Or BC.Text.Contains("5") Or BC.Text.Contains("6") Or BC.Text.Contains("7") Or BC.Text.Contains("8") Or BC.Text.Contains("9") Or BC.Text.Contains("A") Or BC.Text.Contains("B") Or BC.Text.Contains("C") Or BC.Text.Contains("D") Or BC.Text.Contains("E") Or BC.Text.Contains("F") Then
                MsgBox("That is not a number in this base")
                BC.Text = ""
            End If
        End If
        If B.Text = "5" Then

            If BC.Text.Contains("5") Or BC.Text.Contains("6") Or BC.Text.Contains("7") Or BC.Text.Contains("8") Or BC.Text.Contains("9") Or BC.Text.Contains("A") Or BC.Text.Contains("B") Or BC.Text.Contains("C") Or BC.Text.Contains("D") Or BC.Text.Contains("E") Or BC.Text.Contains("F") Then
                MsgBox("That is not a number in this base")
                BC.Text = ""
            End If
        End If
        If B.Text = "6" Then

            If BC.Text.Contains("6") Or BC.Text.Contains("7") Or BC.Text.Contains("8") Or BC.Text.Contains("9") Or BC.Text.Contains("A") Or BC.Text.Contains("B") Or BC.Text.Contains("C") Or BC.Text.Contains("D") Or BC.Text.Contains("E") Or BC.Text.Contains("F") Then
                MsgBox("That is not a number in this base")
                BC.Text = ""
            End If
        End If
        If B.Text = "7" Then
            If BC.Text.Contains("7") Or BC.Text.Contains("8") Or BC.Text.Contains("9") Or BC.Text.Contains("A") Or BC.Text.Contains("B") Or BC.Text.Contains("C") Or BC.Text.Contains("D") Or BC.Text.Contains("E") Or BC.Text.Contains("F") Then
                MsgBox("That is not a number in this base")
                BC.Text = ""
            End If
        End If
        If B.Text = "8" Then
            If BC.Text.Contains("8") Or BC.Text.Contains("9") Or BC.Text.Contains("A") Or BC.Text.Contains("B") Or BC.Text.Contains("C") Or BC.Text.Contains("D") Or BC.Text.Contains("E") Or BC.Text.Contains("F") Then
                MsgBox("That is not a number in this base")
                BC.Text = ""
            End If
        End If
        If B.Text = "9" Then
            If BC.Text.Contains("9") Or BC.Text.Contains("A") Or BC.Text.Contains("B") Or BC.Text.Contains("C") Or BC.Text.Contains("D") Or BC.Text.Contains("E") Or BC.Text.Contains("F") Then
                MsgBox("That is not a number in this base")
                BC.Text = ""
            End If
        End If
        If B.Text = "16" Then
            If BC.Text.Contains("2") Or BC.Text = "" Or BC.Text.Contains("1") Or BC.Text.Contains("0") Or BC.Text.Contains("3") Or BC.Text.Contains("4") Or BC.Text.Contains("5") Or BC.Text.Contains("6") Or BC.Text.Contains("7") Or BC.Text.Contains("8") Or BC.Text.Contains("9") Or BC.Text.Contains("A") Or BC.Text.Contains("B") Or BC.Text.Contains("C") Or BC.Text.Contains("D") Or BC.Text.Contains("E") Or BC.Text.Contains("F") Then
            Else : MsgBox("Error in input. Wrong value. Hexadecimal ranges from 0-9 and A-F")
                BC.Text = ""
            End If
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text.Contains("A") Or TextBox4.Text.Contains("B") Or TextBox4.Text.Contains("C") Or TextBox4.Text.Contains("D") Or TextBox4.Text.Contains("E") Or TextBox4.Text.Contains("F") Then
            MsgBox("That is an Hexadecimal (Base 16) character")
            TextBox4.Text = ""
        End If
    End Sub
End Class