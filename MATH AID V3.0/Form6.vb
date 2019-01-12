Public Class Form6
    Dim s As String
    Dim x As Boolean = False
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Add("_____________________________________________________________________________________________________")
        ListBox1.Items.Add("Using the formula for the nth term of an A.P;")
        ListBox1.Items.Add("          Tn = a + (n - 1) d")
        ListBox1.Items.Add("          Tn = " & a1.Text & " + (" & n1.Text & " - 1) " & d1.Text)
        ListBox1.Items.Add("          Tn = " & a1.Text & " + (" & Val(n1.Text) - 1 & ") " & d1.Text)
        ListBox1.Items.Add("          Tn = " & a1.Text & " + " & (Val(n1.Text) - 1) * Val(d1.Text))
        ListBox1.Items.Add("          Tn = " & Val(a1.Text) + (Val(n1.Text) - 1) * Val(d1.Text))
        If n1.Text.EndsWith("1") Then
            If n1.Text <> ("11") Then
                ListBox1.Items.Add("Therefore, the " & n1.Text & "st term of the A.P is " & Val(a1.Text) + (Val(n1.Text) - 1) * Val(d1.Text))
            End If
        End If
        If n1.Text.EndsWith("2") Then
            If n1.Text <> ("12") Then
                ListBox1.Items.Add("Therefore, the " & n1.Text & "nd term of the A.P is " & Val(a1.Text) + (Val(n1.Text) - 1) * Val(d1.Text))
            End If
        End If
        If n1.Text.EndsWith("3") Then
            If n1.Text <> ("13") Then
                ListBox1.Items.Add("Therefore, the " & n1.Text & "rd term of the A.P is " & Val(a1.Text) + (Val(n1.Text) - 1) * Val(d1.Text))
            End If
        End If
        If n1.Text.Last <> "1" Then
            If n1.Text.Last <> "2" Then
                If n1.Text.Last <> "3" Then
                    ListBox1.Items.Add("Therefore, the " & n1.Text & "th term of the A.P is " & Val(a1.Text) + (Val(n1.Text) - 1) * Val(d1.Text))
                End If
            End If
        End If
        If n1.Text.Last = "1" Then
            If n1.Text = "11" Then
                ListBox1.Items.Add("Therefore, the " & n1.Text & "th term of the A.P is " & Val(a1.Text) + (Val(n1.Text) - 1) * Val(d1.Text))
            End If
        End If
        If n1.Text.Last = "2" Then
            If n1.Text = "12" Then
                ListBox1.Items.Add("Therefore, the " & n1.Text & "th term of the A.P is " & Val(a1.Text) + (Val(n1.Text) - 1) * Val(d1.Text))
            End If
        End If
        If n1.Text.Last = "3" Then
            If n1.Text = "13" Then
                ListBox1.Items.Add("Therefore, the " & n1.Text & "th term of the A.P is " & Val(a1.Text) + (Val(n1.Text) - 1) * Val(d1.Text))
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        x = True
        a1.Text = ""
        n1.Text = ""
        d1.Text = ""
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox2.Items.Add("_____________________________________________________________________________________________________")
        ListBox2.Items.Add("Using the formula for the nth term of an A.P;")
        ListBox2.Items.Add("          a + " & Val(tn1.Text) - 1 & "d = " & an1.Text & "    -------- (1)")
        ListBox2.Items.Add("          a + " & Val(tn2.Text) - 1 & "d = " & an2.Text & "    -------- (2)")
        ListBox2.Items.Add("Subtract Equation (1) from Equation (2)")
        If Val(tn2.Text) - Val(tn1.Text) = 1 Then
            ListBox2.Items.Add("          d = " & Val(an2.Text) - Val(an1.Text))
            ListBox2.Items.Add("Substitute d = " & Val(an2.Text) - Val(an1.Text) & " into equation (1)")
            ListBox2.Items.Add("          a + " & Val(tn1.Text) - 1 & "d = " & an1.Text & "    -------- (1)")
            ListBox2.Items.Add("          a + " & Val(tn1.Text) - 1 & " (" & Val(an2.Text) - Val(an1.Text) & ") = " & an1.Text)
            ListBox2.Items.Add("          a + " & (Val(tn1.Text) - 1) * (Val(an2.Text) - Val(an1.Text)) & " = " & an1.Text)
            Dim d As Double = (Val(tn1.Text) - 1) * (Val(an2.Text) - Val(an1.Text))
            d = -1 * d
            Dim s As String = d
            If s.Contains("-") Then
                s = s.Replace("-", "")
                s = " - " & s
            Else
                s = " + " & s
            End If
            ListBox2.Items.Add("          a = " & Val(an1.Text) & s)
            ListBox2.Items.Add("          a = " & Val(an1.Text) + d)
            ListBox2.Items.Add("Therefore; a = " & Val(an1.Text) + d)
            ListBox2.Items.Add("       and d = " & Val(an2.Text) - Val(an1.Text))
        Else
            ListBox2.Items.Add("          " & Val(tn2.Text) - Val(tn1.Text) & "d = " & Val(an2.Text) - Val(an1.Text))
            ListBox2.Items.Add("          d = " & Val(an2.Text) - Val(an1.Text) & " / " & Val(tn2.Text) - Val(tn1.Text))
            ListBox2.Items.Add("          d = " & (Val(an2.Text) - Val(an1.Text)) / (Val(tn2.Text) - Val(tn1.Text)))
            ListBox2.Items.Add("Substitute d = " & (Val(an2.Text) - Val(an1.Text)) / (Val(tn2.Text) - Val(tn1.Text)) & " into equation (1)")
            ListBox2.Items.Add("          a + " & Val(tn1.Text) - 1 & "d = " & an1.Text & "    -------- (1)")
            ListBox2.Items.Add("          a + " & Val(tn1.Text) - 1 & " (" & (Val(an2.Text) - Val(an1.Text)) / (Val(tn2.Text) - Val(tn1.Text)) & ") = " & an1.Text)
            ListBox2.Items.Add("          a + " & (Val(tn1.Text) - 1) * ((Val(an2.Text) - Val(an1.Text)) / (Val(tn2.Text) - Val(tn1.Text))) & " = " & an1.Text)
            Dim d As Double = (Val(tn1.Text) - 1) * ((Val(an2.Text) - Val(an1.Text)) / (Val(tn2.Text) - Val(tn1.Text)))
            d = -1 * d
            Dim s As String = d
            If s.Contains("-") Then
                s = s.Replace("-", "")
                s = " - " & s
            Else
                s = " + " & s
            End If
            ListBox2.Items.Add("          a = " & Val(an1.Text) & s)
            ListBox2.Items.Add("          a = " & Val(an1.Text) + d)
            ListBox2.Items.Add("Therefore; a = " & Val(an1.Text) + d)
            ListBox2.Items.Add("       and d = " & (Val(an2.Text) - Val(an1.Text)) / (Val(tn2.Text) - Val(tn1.Text)))
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        tn1.Text = ""
        tn2.Text = ""
        an1.Text = ""
        an2.Text = ""
        ListBox2.Items.Clear()
    End Sub
End Class