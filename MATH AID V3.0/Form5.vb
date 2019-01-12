

Public Class Form5
    Dim t As Integer = 0
    Dim x As Integer
    Dim k As Double
    Dim l As Double
    Dim s As Integer = 0
    Dim n As Double
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        t = t + 1
        Dim a As Control
        For Each a In Controls
            If a.Name = "b" & t Then
                Dim b As Control
                For Each b In Controls
                    If b.Name = "a" & t Then
                        Dim c As Control
                        For Each c In Controls
                            If c.Name = "c" & t Then
                                If TypeOf a Is TextBox Then
                                    If TypeOf b Is TextBox Then
                                        If TypeOf c Is TextBox Then
                                            If a.Text <> "" Then
                                                If b.Text <> "" Then
                                                    c.Text = Val(a.Text) * Val(b.Text)
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        Next
                    End If
                Next
            End If
        Next
        If t = 20 Then
            t = 0
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Timer1.Enabled = False
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                If ctl.Name.Contains("a") Then
                    If ctl.Text <> "" Then
                        ListBox2.Items.Add(ctl.Name)
                    End If
                End If
            End If
        Next
        Dim a As Control
        For Each a In Controls
            If TypeOf a Is TextBox Then
                If a.Name = "a" & ListBox2.Items.Count + 1 Then
                    a.Text = "Total (∑)"
                    a.Font = New Font(Font.Bold, 12)
                    Dim ctx As Control
                    For Each ctx In Controls
                        If TypeOf ctx Is TextBox Then
                            If ctx.Name = "c" & ListBox2.Items.Count + 1 Then
                                Dim cty As Control
                                For Each cty In Controls
                                    If TypeOf cty Is TextBox Then
                                        If cty.Name.Contains("c") Then
                                            If cty.Text <> "" Then
                                                ctx.Text = Val(ctx.Text) + Val(cty.Text)
                                            End If
                                        End If
                                    End If
                                Next
                            End If
                        End If
                    Next
                End If
            End If
        Next
        Dim ctu As Control
        For Each ctu In Controls
            If TypeOf ctu Is TextBox Then
                If ctu.Name = "b" & ListBox2.Items.Count + 1 Then
                    Dim ctv As Control
                    For Each ctv In Controls
                        If TypeOf ctv Is TextBox Then
                            If ctv.Name.Contains("b") Then
                                If ctv.Text <> "" Then
                                    ctu.Text = Val(ctu.Text) + Val(ctv.Text)
                                End If
                            End If
                        End If
                    Next
                End If
            End If
        Next
        Dim g As Control
        For Each g In Controls
            If TypeOf g Is TextBox Then
                If g.Name = "b" & ListBox2.Items.Count + 1 Then
                    Dim h As Control
                    For Each h In Controls
                        If TypeOf h Is TextBox Then
                            If h.Name = "c" & ListBox2.Items.Count + 1 Then
                                Dim x As Double = g.Text
                                n = g.Text
                                Dim y As Double = h.Text
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("Mean (n) = ∑fx / ∑f")
                                ListBox1.Items.Add("         = " & h.Text & " / " & g.Text)
                                ListBox1.Items.Add("         = " & (Val(h.Text) / Val(g.Text)))
                                ListBox1.Items.Add("Therefore; Mean (n) = " & CStr(Math.Round((Val(h.Text) / Val(g.Text)), 4)) & "  - To 4 d.p")
                                k = CStr(Math.Round(Val(h.Text) / Val(g.Text), 4))
                            End If
                        End If
                    Next
                End If
            End If
        Next
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        s = s + 1
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                If ctl.Name = "d" & s Then
                    Dim ctm As Control
                    For Each ctm In Controls
                        If TypeOf ctm Is TextBox Then
                            If ctm.Name = "a" & s Then
                                ctl.Text = Val(ctm.Text) - k
                                ctl.Text = CStr(Math.Round(Val(ctl.Text), 4))
                            End If
                        End If
                    Next
                End If
            End If
        Next
        Dim ctg As Control
        For Each ctg In Controls
            If TypeOf ctg Is TextBox Then
                If ctg.Name = "e" & s Then
                    Dim cth As Control
                    For Each cth In Controls
                        If TypeOf cth Is TextBox Then
                            If cth.Name = "d" & s Then
                                ctg.Text = Val(cth.Text) ^ 2
                                ctg.Text = CStr(Math.Round(Val(ctg.Text), 4))
                            End If
                        End If
                    Next
                End If
            End If
        Next
        Dim ctu As Control
        For Each ctu In Controls
            If TypeOf ctu Is TextBox Then
                If ctu.Name = "d" & s Then
                    Dim ctv As Control
                    For Each ctv In Controls
                        If TypeOf ctv Is TextBox Then
                            If ctv.Name = "a" & s Then
                                ctu.Text = Val(ctv.Text) - k
                                ctu.Text = CStr(Math.Round(Val(ctu.Text), 4))
                            End If
                        End If
                    Next
                End If
            End If
        Next
        Dim cto As Control
        For Each cto In Controls
            If TypeOf cto Is TextBox Then
                If cto.Name = "e" & s Then
                    Dim ctp As Control
                    For Each ctp In Controls
                        If TypeOf ctp Is TextBox Then
                            If ctp.Name = "b" & s Then
                                Dim gj As Control
                                For Each gj In Controls
                                    If TypeOf gj Is TextBox Then
                                        If gj.Name = "f" & s Then
                                            gj.Text = Val(cto.Text) * Val(ctp.Text)
                                            gj.Text = CStr(Math.Round(Val(gj.Text), 4))
                                            Dim cj As Control
                                            For Each cj In Controls
                                                If TypeOf cj Is TextBox Then
                                                    If cj.Name = "f" & ListBox2.Items.Count + 1 Then
                                                        cj.Text = Val(cj.Text) + Val(gj.Text)
                                                        l = cj.Text
                                                    End If
                                                End If
                                            Next
                                        End If
                                    End If
                                Next
                            End If
                        End If
                    Next
                End If
            End If
        Next
        If s = ListBox2.Items.Count Then
            Timer3.Enabled = True
            Timer2.Enabled = False
        End If

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        ListBox1.Items.Add("Variance (V) = ∑f (x - n)^2 / ∑f")
        ListBox1.Items.Add("             = " & l & " / " & n)
        ListBox1.Items.Add("             = " & l / n)
        ListBox1.Items.Add("Standard Deviation (S.D) = SQRT (Variance)")
        ListBox1.Items.Add("             = SQRT (" & l / n & ")")
        ListBox1.Items.Add("             = " & CStr(Math.Sqrt(l / n)))
        Timer3.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
                t = 0
                x = 0
                k = 0
                l = 0
                s = 0
                n = 0
                ctl.Font = a1.Font
            End If
        Next
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        Timer1.Enabled = True
    End Sub
End Class