Public Class Form3
    Dim t As Integer
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        MsgBox("You are to fill the appropriate Boxes with the available values and this aid solves for the rest of the missing values if possible.", MsgBoxStyle.Information, "HELP AND INFO")
    End Sub
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        MsgBox("This software is a product of BTC CORP Community. Members of the team are; Edinyanga Ottoho (CEO), Victory Zibril (Program Manager) and Imikan Umoinyang (Software Informant)", MsgBoxStyle.Information, "ABOUT US")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ctC As Control
        For Each ctC In Controls
            If TypeOf ctC Is TextBox Then
                If ctC.Text = "" Then
                    t = t + 1
                End If
            End If
        Next
        If t >= 4 Then
            MsgBox("You must provide up to three Parameters", MsgBoxStyle.Critical, "Invalid Input")
        End If
        If t <= 3 Then
            If A1.Text <> "" Then
                If A2.Text <> "" Then
                    If B1.Text <> "" Then
                        If B2.Text = "" Then
                            ListBox1.Items.Add("______________________________________________________________________________________________________________________")
                            ListBox1.Items.Add("          Using Sine Rule;")
                            ListBox1.Items.Add("                    SinA / a = SinB / b")
                            ListBox1.Items.Add("                    Sin (" & A1.Text & ") / " & A2.Text & " = Sin (" & B1.Text & ") / b")
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & " / " & A2.Text & " = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) & " / b")))))
                            ListBox1.Items.Add("                    Cross Multiply")
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & " * b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) & " * " & A2.Text)))))
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & "b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(A2.Text))))))
                            ListBox1.Items.Add("                    b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(A2.Text))) & " / " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951))))
                            ListBox1.Items.Add("          Therefore; b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(A2.Text))) / (CStr(Math.Sin(Val(A1.Text) / 57.29577951))))
                            B2.Text = (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(A2.Text))) / (CStr(Math.Sin(Val(A1.Text) / 57.29577951)))
                            If C1.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("                    C = 180 - (" & A1.Text & " + " & B1.Text & ") -          Sum of angles in a triangle")
                                ListBox1.Items.Add("                    C = 180 - (" & Val(A1.Text) + Val(B1.Text) & ")")
                                ListBox1.Items.Add("                    C = " & 180 - (Val(A1.Text) + Val(B1.Text)))
                                ListBox1.Items.Add("          Therefore; C = " & 180 - (Val(A1.Text) + Val(B1.Text)))
                                C1.Text = 180 - (Val(A1.Text) + Val(B1.Text))
                            End If
                            If C2.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("          Using Sine Rule;")
                                ListBox1.Items.Add("                    SinA / a = SinC / c")
                                ListBox1.Items.Add("                    Sin (" & A1.Text & ") / " & A2.Text & " = Sin (" & C1.Text & ") / c")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & " / " & A2.Text & " = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) & " / c")))))
                                ListBox1.Items.Add("                    Cross Multiply")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & " * c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) & " * " & A2.Text)))))
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & "c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(A2.Text))))))
                                ListBox1.Items.Add("                    c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(A2.Text))) & " / " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951))))
                                ListBox1.Items.Add("          Therefore; c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(A2.Text))) / (CStr(Math.Sin(Val(A1.Text) / 57.29577951))))
                                C2.Text = (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(A2.Text))) / (CStr(Math.Sin(Val(A1.Text) / 57.29577951)))
                            End If
                        End If
                    End If
                End If
            End If
            If A1.Text <> "" Then
                If A2.Text <> "" Then
                    If B1.Text = "" Then
                        If B2.Text <> "" Then
                            ListBox1.Items.Add("______________________________________________________________________________________________________________________")
                            ListBox1.Items.Add("          Using Sine Rule;")
                            ListBox1.Items.Add("                    SinA / a = SinB / b")
                            ListBox1.Items.Add("                    Sin (" & A1.Text & ") / " & A2.Text & " = SinB / " & Val(B2.Text))
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & " / " & A2.Text & " = SinB / " & Val(B2.Text))))
                            ListBox1.Items.Add("                    Cross Multiply")
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & " * " & Val(B2.Text) & " = SinB * " & A2.Text)))
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) * Val(B2.Text) & " = " & Val(A2.Text) & "SinB")))
                            ListBox1.Items.Add("                    SinB = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(B2.Text))) & " / " & (Val(A2.Text)))
                            ListBox1.Items.Add("                    SinB = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(B2.Text))) / (Val(A2.Text)))
                            ListBox1.Items.Add("                       B = " & "Sin-1 (" & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(B2.Text))) / Val(A2.Text) & ")")
                            Dim B As Double = ((CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(B2.Text))) / Val(A2.Text))
                            ListBox1.Items.Add("                       B = " & CStr(Math.Asin(B)) * 57.29577951)
                            ListBox1.Items.Add("          Therefore;   B = " & CStr(Math.Asin(B)) * 57.29577951)
                            B1.Text = CStr(Math.Asin(B) * 57.29577951)
                            If C1.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("                    C = 180 - (" & A1.Text & " + " & B1.Text & ") -          Sum of angles in a triangle")
                                ListBox1.Items.Add("                    C = 180 - (" & Val(A1.Text) + Val(B1.Text) & ")")
                                ListBox1.Items.Add("                    C = " & 180 - (Val(A1.Text) + Val(B1.Text)))
                                ListBox1.Items.Add("          Therefore; C = " & 180 - (Val(A1.Text) + Val(B1.Text)))
                                C1.Text = 180 - (Val(A1.Text) + Val(B1.Text))
                            End If
                            If C2.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("          Using Sine Rule;")
                                ListBox1.Items.Add("                    SinA / a = SinC / c")
                                ListBox1.Items.Add("                    Sin (" & A1.Text & ") / " & A2.Text & " = Sin (" & C1.Text & ") / c")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & " / " & A2.Text & " = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) & " / c")))))
                                ListBox1.Items.Add("                    Cross Multiply")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & " * c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) & " * " & A2.Text)))))
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & "c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(A2.Text))))))
                                ListBox1.Items.Add("                    c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(A2.Text))) & " / " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951))))
                                ListBox1.Items.Add("          Therefore; c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(A2.Text))) / (CStr(Math.Sin(Val(A1.Text) / 57.29577951))))
                                C2.Text = (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(A2.Text))) / (CStr(Math.Sin(Val(A1.Text) / 57.29577951)))
                            End If
                        End If
                    End If
                End If
            End If
            If A1.Text <> "" Then
                If A2.Text <> "" Then
                    If C1.Text <> "" Then
                        If C2.Text = "" Then
                            ListBox1.Items.Add("______________________________________________________________________________________________________________________")
                            ListBox1.Items.Add("          Using Sine Rule;")
                            ListBox1.Items.Add("                    SinA / a = SinC / c")
                            ListBox1.Items.Add("                    Sin (" & A1.Text & ") / " & A2.Text & " = Sin (" & C1.Text & ") / c")
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & " / " & A2.Text & " = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) & " / c")))))
                            ListBox1.Items.Add("                    Cross Multiply")
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & " * c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) & " * " & A2.Text)))))
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & "c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(A2.Text))))))
                            ListBox1.Items.Add("                    c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(A2.Text))) & " / " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951))))
                            ListBox1.Items.Add("          Therefore; c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(A2.Text))) / (CStr(Math.Sin(Val(A1.Text) / 57.29577951))))
                            C2.Text = (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(A2.Text))) / (CStr(Math.Sin(Val(A1.Text) / 57.29577951)))
                            If B1.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("                    B = 180 - (" & A1.Text & " + " & C1.Text & ") -          Sum of angles in a triangle")
                                ListBox1.Items.Add("                    B = 180 - (" & Val(A1.Text) + Val(C1.Text) & ")")
                                ListBox1.Items.Add("                    B = " & 180 - (Val(A1.Text) + Val(C1.Text)))
                                ListBox1.Items.Add("          Therefore; B = " & 180 - (Val(A1.Text) + Val(C1.Text)))
                                B1.Text = 180 - (Val(A1.Text) + Val(C1.Text))
                            End If
                            If B2.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("          Using Sine Rule;")
                                ListBox1.Items.Add("                    SinA / a = SinB / b")
                                ListBox1.Items.Add("                    Sin (" & A1.Text & ") / " & A2.Text & " = Sin (" & B1.Text & ") / b")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & " / " & A2.Text & " = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) & " / b")))))
                                ListBox1.Items.Add("                    Cross Multiply")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & " * b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) & " * " & A2.Text)))))
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & "b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(A2.Text))))))
                                ListBox1.Items.Add("                    b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(A2.Text))) & " / " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951))))
                                ListBox1.Items.Add("          Therefore; b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(A2.Text))) / (CStr(Math.Sin(Val(A1.Text) / 57.29577951))))
                                B2.Text = (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(A2.Text))) / (CStr(Math.Sin(Val(A1.Text) / 57.29577951)))
                            End If
                        End If
                    End If
                End If
            End If
            If A1.Text <> "" Then
                If A2.Text <> "" Then
                    If C1.Text = "" Then
                        If C2.Text <> "" Then
                            ListBox1.Items.Add("______________________________________________________________________________________________________________________")
                            ListBox1.Items.Add("          Using Sine Rule;")
                            ListBox1.Items.Add("                    SinA / a = SinC / c")
                            ListBox1.Items.Add("                    Sin (" & A1.Text & ") / " & A2.Text & " = SinC / " & Val(C2.Text))
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & " / " & A2.Text & " = SinC / " & Val(C2.Text))))
                            ListBox1.Items.Add("                    Cross Multiply")
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & " * " & Val(C2.Text) & " = SinC * " & A2.Text)))
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) * Val(C2.Text) & " = " & Val(A2.Text) & "SinC")))
                            ListBox1.Items.Add("                    SinC = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(C2.Text))) & " / " & (Val(A2.Text)))
                            ListBox1.Items.Add("                    SinC = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(C2.Text))) / (Val(A2.Text)))
                            ListBox1.Items.Add("                       C = " & "Sin-1 (" & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(C2.Text))) / Val(A2.Text) & ")")
                            Dim B As Double = ((CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(C2.Text))) / Val(A2.Text))
                            ListBox1.Items.Add("                       C = " & CStr(Math.Asin(B)) * 57.29577951)
                            ListBox1.Items.Add("          Therefore;   C = " & CStr(Math.Asin(B)) * 57.29577951)
                            C1.Text = CStr(Math.Asin(B) * 57.29577951)
                            If B1.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("                    B = 180 - (" & A1.Text & " + " & C1.Text & ") -          Sum of angles in a triangle")
                                ListBox1.Items.Add("                    B = 180 - (" & Val(A1.Text) + Val(C1.Text) & ")")
                                ListBox1.Items.Add("                    B = " & 180 - (Val(A1.Text) + Val(C1.Text)))
                                ListBox1.Items.Add("          Therefore; B = " & 180 - (Val(A1.Text) + Val(C1.Text)))
                                B1.Text = 180 - (Val(A1.Text) + Val(C1.Text))
                            End If
                            If B2.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("          Using Sine Rule;")
                                ListBox1.Items.Add("                    SinA / a = SinB / b")
                                ListBox1.Items.Add("                    Sin (" & A1.Text & ") / " & A2.Text & " = Sin (" & B1.Text & ") / b")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & " / " & A2.Text & " = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) & " / b")))))
                                ListBox1.Items.Add("                    Cross Multiply")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & " * b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) & " * " & A2.Text)))))
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & "b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(A2.Text))))))
                                ListBox1.Items.Add("                    b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(A2.Text))) & " / " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951))))
                                ListBox1.Items.Add("          Therefore; b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(A2.Text))) / (CStr(Math.Sin(Val(A1.Text) / 57.29577951))))
                                B2.Text = (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(A2.Text))) / (CStr(Math.Sin(Val(A1.Text) / 57.29577951)))
                            End If
                        End If
                    End If
                End If
            End If
            If B1.Text <> "" Then
                If B2.Text <> "" Then
                    If C1.Text <> "" Then
                        If C2.Text = "" Then
                            ListBox1.Items.Add("______________________________________________________________________________________________________________________")
                            ListBox1.Items.Add("          Using Sine Rule;")
                            ListBox1.Items.Add("                    SinB / b = SinC / c")
                            ListBox1.Items.Add("                    Sin (" & B1.Text & ") / " & B2.Text & " = Sin (" & C1.Text & ") / c")
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & " / " & B2.Text & " = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) & " / c")))))
                            ListBox1.Items.Add("                    Cross Multiply")
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & " * c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) & " * " & B2.Text)))))
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & "c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(B2.Text))))))
                            ListBox1.Items.Add("                    c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(B2.Text))) & " / " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951))))
                            ListBox1.Items.Add("          Therefore; c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(B2.Text))) / (CStr(Math.Sin(Val(B1.Text) / 57.29577951))))
                            C2.Text = (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(B2.Text))) / (CStr(Math.Sin(Val(B1.Text) / 57.29577951)))
                            If A1.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("                    A = 180 - (" & B1.Text & " + " & C1.Text & ") -          Sum of angles in a triangle")
                                ListBox1.Items.Add("                    A = 180 - (" & Val(B1.Text) + Val(C1.Text) & ")")
                                ListBox1.Items.Add("                    A = " & 180 - (Val(B1.Text) + Val(C1.Text)))
                                ListBox1.Items.Add("          Therefore; A = " & 180 - (Val(B1.Text) + Val(C1.Text)))
                                A1.Text = 180 - (Val(B1.Text) + Val(C1.Text))
                            End If
                            If A2.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("          Using Sine Rule;")
                                ListBox1.Items.Add("                    SinA / a = SinA / a")
                                ListBox1.Items.Add("                    Sin (" & B1.Text & ") / " & B2.Text & " = Sin (" & A1.Text & ") / a")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & " / " & B2.Text & " = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) & " / b")))))
                                ListBox1.Items.Add("                    Cross Multiply")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & " * a = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) & " * " & B2.Text)))))
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & "a = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(B2.Text))))))
                                ListBox1.Items.Add("                    a = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(B2.Text))) & " / " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951))))
                                ListBox1.Items.Add("          Therefore; a = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(B2.Text))) / (CStr(Math.Sin(Val(B1.Text) / 57.29577951))))
                                A2.Text = (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(B2.Text))) / (CStr(Math.Sin(Val(B1.Text) / 57.29577951)))
                            End If
                        End If
                    End If
                End If
            End If
            If B1.Text <> "" Then
                If B2.Text <> "" Then
                    If C1.Text = "" Then
                        If C2.Text <> "" Then
                            ListBox1.Items.Add("______________________________________________________________________________________________________________________")
                            ListBox1.Items.Add("          Using Sine Rule;")
                            ListBox1.Items.Add("                    SinB / b = SinC / c")
                            ListBox1.Items.Add("                    Sin (" & B1.Text & ") / " & B2.Text & " = SinC / " & Val(C2.Text))
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & " / " & B2.Text & " = SinC / " & Val(C2.Text))))
                            ListBox1.Items.Add("                    Cross Multiply")
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & " * " & Val(C2.Text) & " = SinC * " & B2.Text)))
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) * Val(C2.Text) & " = " & Val(B2.Text) & "SinC")))
                            ListBox1.Items.Add("                    SinC = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(C2.Text))) & " / " & (Val(B2.Text)))
                            ListBox1.Items.Add("                    SinC = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(C2.Text))) / (Val(B2.Text)))
                            ListBox1.Items.Add("                       C = " & "Sin-1 (" & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(C2.Text))) / Val(B2.Text) & ")")
                            Dim B As Double = ((CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(C2.Text))) / Val(B2.Text))
                            ListBox1.Items.Add("                       C = " & CStr(Math.Asin(B)) * 57.29577951)
                            ListBox1.Items.Add("          Therefore;   C = " & CStr(Math.Asin(B)) * 57.29577951)
                            C1.Text = CStr(Math.Asin(B) * 57.29577951)
                            If A1.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("                    A = 180 - (" & B1.Text & " + " & C1.Text & ") -          Sum of angles in a triangle")
                                ListBox1.Items.Add("                    A = 180 - (" & Val(B1.Text) + Val(C1.Text) & ")")
                                ListBox1.Items.Add("                    A = " & 180 - (Val(B1.Text) + Val(C1.Text)))
                                ListBox1.Items.Add("          Therefore; A = " & 180 - (Val(B1.Text) + Val(C1.Text)))
                                A1.Text = 180 - (Val(B1.Text) + Val(C1.Text))
                            End If
                            If A2.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("          Using Sine Rule;")
                                ListBox1.Items.Add("                    SinB / b = SinA / a")
                                ListBox1.Items.Add("                    Sin (" & B1.Text & ") / " & B2.Text & " = Sin (" & A1.Text & ") / a")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & " / " & B2.Text & " = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) & " / a")))))
                                ListBox1.Items.Add("                    Cross Multiply")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & " * a = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) & " * " & B2.Text)))))
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & "a = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(B2.Text))))))
                                ListBox1.Items.Add("                    a = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(B2.Text))) & " / " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951))))
                                ListBox1.Items.Add("          Therefore; a = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(B2.Text))) / (CStr(Math.Sin(Val(B1.Text) / 57.29577951))))
                                A2.Text = (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(B2.Text))) / (CStr(Math.Sin(Val(B1.Text) / 57.29577951)))
                            End If
                        End If
                    End If
                End If
            End If
            If B1.Text <> "" Then
                If B2.Text <> "" Then
                    If A1.Text <> "" Then
                        If A2.Text = "" Then
                            ListBox1.Items.Add("______________________________________________________________________________________________________________________")
                            ListBox1.Items.Add("          Using Sine Rule;")
                            ListBox1.Items.Add("                    SinB / b = SinA / a")
                            ListBox1.Items.Add("                    Sin (" & B1.Text & ") / " & B2.Text & " = Sin (" & A1.Text & ") / a")
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & " / " & B2.Text & " = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) & " / a")))))
                            ListBox1.Items.Add("                    Cross Multiply")
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & " * a = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) & " * " & B2.Text)))))
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & "a = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(B2.Text))))))
                            ListBox1.Items.Add("                    a = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(B2.Text))) & " / " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951))))
                            ListBox1.Items.Add("          Therefore; a = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(B2.Text))) / (CStr(Math.Sin(Val(B1.Text) / 57.29577951))))
                            A2.Text = (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(B2.Text))) / (CStr(Math.Sin(Val(B1.Text) / 57.29577951)))
                            If C1.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("                    C = 180 - (" & B1.Text & " + " & A1.Text & ") -          Sum of angles in a triangle")
                                ListBox1.Items.Add("                    C = 180 - (" & Val(B1.Text) + Val(A1.Text) & ")")
                                ListBox1.Items.Add("                    C = " & 180 - (Val(B1.Text) + Val(A1.Text)))
                                ListBox1.Items.Add("          Therefore; C = " & 180 - (Val(B1.Text) + Val(A1.Text)))
                                C1.Text = 180 - (Val(B1.Text) + Val(A1.Text))
                            End If
                            If C2.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("          Using Sine Rule;")
                                ListBox1.Items.Add("                    SinB / b = SinC / c")
                                ListBox1.Items.Add("                    Sin (" & B1.Text & ") / " & B2.Text & " = Sin (" & C1.Text & ") / c")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & " / " & B2.Text & " = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) & " / c")))))
                                ListBox1.Items.Add("                    Cross Multiply")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & " * c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) & " * " & B2.Text)))))
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & "c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(B2.Text))))))
                                ListBox1.Items.Add("                    c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(B2.Text))) & " / " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951))))
                                ListBox1.Items.Add("          Therefore; c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(B2.Text))) / (CStr(Math.Sin(Val(B1.Text) / 57.29577951))))
                                C2.Text = (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(B2.Text))) / (CStr(Math.Sin(Val(B1.Text) / 57.29577951)))
                            End If
                        End If
                    End If
                End If
            End If
            If B1.Text <> "" Then
                If B2.Text <> "" Then
                    If A1.Text = "" Then
                        If A2.Text <> "" Then
                            ListBox1.Items.Add("______________________________________________________________________________________________________________________")
                            ListBox1.Items.Add("          Using Sine Rule;")
                            ListBox1.Items.Add("                    SinB / b = SinA / a")
                            ListBox1.Items.Add("                    Sin (" & B1.Text & ") / " & B2.Text & " = SinA / " & Val(A2.Text))
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & " / " & B2.Text & " = SinA / " & Val(A2.Text))))
                            ListBox1.Items.Add("                    Cross Multiply")
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & " * " & Val(A2.Text) & " = SinA * " & B2.Text)))
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) * Val(A2.Text) & " = " & Val(B2.Text) & "SinA")))
                            ListBox1.Items.Add("                    SinA = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(A2.Text))) & " / " & (Val(B2.Text)))
                            ListBox1.Items.Add("                    SinA = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(A2.Text))) / (Val(B2.Text)))
                            ListBox1.Items.Add("                       A = " & "Sin-1 (" & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(A2.Text))) / Val(B2.Text) & ")")
                            Dim B As Double = ((CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(A2.Text))) / Val(B2.Text))
                            ListBox1.Items.Add("                       A = " & CStr(Math.Asin(B)) * 57.29577951)
                            ListBox1.Items.Add("          Therefore;   A = " & CStr(Math.Asin(B)) * 57.29577951)
                            A1.Text = CStr(Math.Asin(B) * 57.29577951)
                            If C1.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("                    C = 180 - (" & B1.Text & " + " & A1.Text & ") -          Sum of angles in a triangle")
                                ListBox1.Items.Add("                    C = 180 - (" & Val(B1.Text) + Val(A1.Text) & ")")
                                ListBox1.Items.Add("                    C = " & 180 - (Val(B1.Text) + Val(A1.Text)))
                                ListBox1.Items.Add("          Therefore; C = " & 180 - (Val(B1.Text) + Val(A1.Text)))
                                C1.Text = 180 - (Val(B1.Text) + Val(A1.Text))
                            End If
                            If C2.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("          Using Sine Rule;")
                                ListBox1.Items.Add("                    SinB / b = SinC / c")
                                ListBox1.Items.Add("                    Sin (" & B1.Text & ") / " & B2.Text & " = Sin (" & C1.Text & ") / c")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & " / " & B2.Text & " = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) & " / c")))))
                                ListBox1.Items.Add("                    Cross Multiply")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & " * c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) & " * " & B2.Text)))))
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & "c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(B2.Text))))))
                                ListBox1.Items.Add("                    c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(B2.Text))) & " / " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951))))
                                ListBox1.Items.Add("          Therefore; c = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(B2.Text))) / (CStr(Math.Sin(Val(B1.Text) / 57.29577951))))
                                C2.Text = (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(B2.Text))) / (CStr(Math.Sin(Val(B1.Text) / 57.29577951)))
                            End If
                        End If
                    End If
                End If
            End If
            If C1.Text <> "" Then
                If C2.Text <> "" Then
                    If A1.Text <> "" Then
                        If A2.Text = "" Then
                            ListBox1.Items.Add("______________________________________________________________________________________________________________________")
                            ListBox1.Items.Add("          Using Sine Rule;")
                            ListBox1.Items.Add("                    SinC / c = SinA / a")
                            ListBox1.Items.Add("                    Sin (" & C1.Text & ") / " & C2.Text & " = Sin (" & A1.Text & ") / a")
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & " / " & C2.Text & " = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) & " / a")))))
                            ListBox1.Items.Add("                    Cross Multiply")
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & " * a = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) & " * " & C2.Text)))))
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & "a = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(C2.Text))))))
                            ListBox1.Items.Add("                    a = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(C2.Text))) & " / " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951))))
                            ListBox1.Items.Add("          Therefore; a = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(C2.Text))) / (CStr(Math.Sin(Val(C1.Text) / 57.29577951))))
                            A2.Text = (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(C2.Text))) / (CStr(Math.Sin(Val(C1.Text) / 57.29577951)))
                            If B1.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("                    B = 180 - (" & C1.Text & " + " & A1.Text & ") -          Sum of angles in a triangle")
                                ListBox1.Items.Add("                    B = 180 - (" & Val(C1.Text) + Val(A1.Text) & ")")
                                ListBox1.Items.Add("                    B = " & 180 - (Val(C1.Text) + Val(A1.Text)))
                                ListBox1.Items.Add("          Therefore; B = " & 180 - (Val(C1.Text) + Val(A1.Text)))
                                B1.Text = 180 - (Val(C1.Text) + Val(A1.Text))
                            End If
                            If B2.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("          Using Sine Rule;")
                                ListBox1.Items.Add("                    SinC / c = SinB / b")
                                ListBox1.Items.Add("                    Sin (" & C1.Text & ") / " & C2.Text & " = Sin (" & B1.Text & ") / b")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & " / " & C2.Text & " = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) & " / b")))))
                                ListBox1.Items.Add("                    Cross Multiply")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & " * b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) & " * " & C2.Text)))))
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & "b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(C2.Text))))))
                                ListBox1.Items.Add("                    b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(C2.Text))) & " / " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951))))
                                ListBox1.Items.Add("          Therefore; b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(C2.Text))) / (CStr(Math.Sin(Val(C1.Text) / 57.29577951))))
                                B2.Text = (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(C2.Text))) / (CStr(Math.Sin(Val(C1.Text) / 57.29577951)))
                            End If
                        End If
                    End If
                End If
            End If
            If C1.Text <> "" Then
                If C2.Text <> "" Then
                    If A1.Text = "" Then
                        If A2.Text <> "" Then
                            ListBox1.Items.Add("______________________________________________________________________________________________________________________")
                            ListBox1.Items.Add("          Using Sine Rule;")
                            ListBox1.Items.Add("                    SinC / c = SinA / a")
                            ListBox1.Items.Add("                    Sin (" & C1.Text & ") / " & C2.Text & " = SinA / " & Val(A2.Text))
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & " / " & C2.Text & " = SinA / " & Val(A2.Text))))
                            ListBox1.Items.Add("                    Cross Multiply")
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & " * " & Val(A2.Text) & " = SinA * " & C2.Text)))
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) * Val(A2.Text) & " = " & Val(C2.Text) & "SinA")))
                            ListBox1.Items.Add("                    SinA = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(A2.Text))) & " / " & (Val(C2.Text)))
                            ListBox1.Items.Add("                    SinA = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(A2.Text))) / (Val(C2.Text)))
                            ListBox1.Items.Add("                       A = " & "Sin-1 (" & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(A2.Text))) / Val(C2.Text) & ")")
                            Dim B As Double = ((CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(A2.Text))) / Val(C2.Text))
                            ListBox1.Items.Add("                       A = " & CStr(Math.Asin(B)) * 57.29577951)
                            ListBox1.Items.Add("          Therefore;   A = " & CStr(Math.Asin(B)) * 57.29577951)
                            A1.Text = CStr(Math.Asin(B) * 57.29577951)
                            If B1.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("                    B = 180 - (" & C1.Text & " + " & A1.Text & ") -          Sum of angles in a triangle")
                                ListBox1.Items.Add("                    B = 180 - (" & Val(C1.Text) + Val(A1.Text) & ")")
                                ListBox1.Items.Add("                    B = " & 180 - (Val(C1.Text) + Val(A1.Text)))
                                ListBox1.Items.Add("          Therefore; B = " & 180 - (Val(C1.Text) + Val(A1.Text)))
                                B1.Text = 180 - (Val(C1.Text) + Val(A1.Text))
                            End If
                            If B2.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("          Using Sine Rule;")
                                ListBox1.Items.Add("                    SinC / c = SinB / b")
                                ListBox1.Items.Add("                    Sin (" & C1.Text & ") / " & C2.Text & " = Sin (" & B1.Text & ") / b")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & " / " & C2.Text & " = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) & " / b")))))
                                ListBox1.Items.Add("                    Cross Multiply")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & " * b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) & " * " & C2.Text)))))
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & "b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(C2.Text))))))
                                ListBox1.Items.Add("                    b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(C2.Text))) & " / " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951))))
                                ListBox1.Items.Add("          Therefore; b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(C2.Text))) / (CStr(Math.Sin(Val(C1.Text) / 57.29577951))))
                                B2.Text = (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(C2.Text))) / (CStr(Math.Sin(Val(C1.Text) / 57.29577951)))
                            End If
                        End If
                    End If
                End If
            End If
            If C1.Text <> "" Then
                If C2.Text <> "" Then
                    If B1.Text <> "" Then
                        If B2.Text = "" Then
                            ListBox1.Items.Add("______________________________________________________________________________________________________________________")
                            ListBox1.Items.Add("          Using Sine Rule;")
                            ListBox1.Items.Add("                    SinC / c = SinB / b")
                            ListBox1.Items.Add("                    Sin (" & C1.Text & ") / " & C2.Text & " = Sin (" & B1.Text & ") / b")
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & " / " & C2.Text & " = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) & " / b")))))
                            ListBox1.Items.Add("                    Cross Multiply")
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & " * b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) & " * " & C2.Text)))))
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & "b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(C2.Text))))))
                            ListBox1.Items.Add("                    b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(C2.Text))) & " / " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951))))
                            ListBox1.Items.Add("          Therefore; b = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(C2.Text))) / (CStr(Math.Sin(Val(C1.Text) / 57.29577951))))
                            B2.Text = (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(C2.Text))) / (CStr(Math.Sin(Val(C1.Text) / 57.29577951)))
                            If A1.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("                    A = 180 - (" & C1.Text & " + " & B1.Text & ") -          Sum of angles in a triangle")
                                ListBox1.Items.Add("                    A = 180 - (" & Val(C1.Text) + Val(B1.Text) & ")")
                                ListBox1.Items.Add("                    A = " & 180 - (Val(C1.Text) + Val(B1.Text)))
                                ListBox1.Items.Add("          Therefore; A = " & 180 - (Val(C1.Text) + Val(B1.Text)))
                                A1.Text = 180 - (Val(C1.Text) + Val(B1.Text))
                            End If
                            If A2.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("          Using Sine Rule;")
                                ListBox1.Items.Add("                    SinC / c = SinA / a")
                                ListBox1.Items.Add("                    Sin (" & C1.Text & ") / " & C2.Text & " = Sin (" & A1.Text & ") / a")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & " / " & C2.Text & " = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) & " / b")))))
                                ListBox1.Items.Add("                    Cross Multiply")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & " * a = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) & " * " & C2.Text)))))
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & "a = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(C2.Text))))))
                                ListBox1.Items.Add("                    a = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(C2.Text))) & " / " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951))))
                                ListBox1.Items.Add("          Therefore; a = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(C2.Text))) / (CStr(Math.Sin(Val(C1.Text) / 57.29577951))))
                                A2.Text = (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(C2.Text))) / (CStr(Math.Sin(Val(C1.Text) / 57.29577951)))
                            End If
                        End If
                    End If
                End If
            End If
            If C1.Text <> "" Then
                If C2.Text <> "" Then
                    If B1.Text = "" Then
                        If B2.Text <> "" Then
                            ListBox1.Items.Add("______________________________________________________________________________________________________________________")
                            ListBox1.Items.Add("          Using Sine Rule;")
                            ListBox1.Items.Add("                    SinC / c = SinB / b")
                            ListBox1.Items.Add("                    Sin (" & C1.Text & ") / " & C2.Text & " = SinB / " & Val(B2.Text))
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & " / " & C2.Text & " = SinB / " & Val(B2.Text))))
                            ListBox1.Items.Add("                    Cross Multiply")
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & " * " & Val(B2.Text) & " = SinB * " & C2.Text)))
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) * Val(B2.Text) & " = " & Val(C2.Text) & "SinB")))
                            ListBox1.Items.Add("                    SinB = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(B2.Text))) & " / " & (Val(C2.Text)))
                            ListBox1.Items.Add("                    SinB = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(B2.Text))) / (Val(C2.Text)))
                            ListBox1.Items.Add("                       B = " & "Sin-1 (" & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(B2.Text))) / Val(C2.Text) & ")")
                            Dim B As Double = ((CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(B2.Text))) / Val(C2.Text))
                            ListBox1.Items.Add("                       B = " & CStr(Math.Asin(B)) * 57.29577951)
                            ListBox1.Items.Add("          Therefore;   B = " & CStr(Math.Asin(B)) * 57.29577951)
                            B1.Text = CStr(Math.Asin(B) * 57.29577951)
                            If A1.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("                    A = 180 - (" & C1.Text & " + " & B1.Text & ") -          Sum of angles in a triangle")
                                ListBox1.Items.Add("                    A = 180 - (" & Val(C1.Text) + Val(B1.Text) & ")")
                                ListBox1.Items.Add("                    A = " & 180 - (Val(C1.Text) + Val(B1.Text)))
                                ListBox1.Items.Add("          Therefore; A = " & 180 - (Val(C1.Text) + Val(B1.Text)))
                                A1.Text = 180 - (Val(C1.Text) + Val(B1.Text))
                            End If
                            If A2.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("          Using Sine Rule;")
                                ListBox1.Items.Add("                    SinC / c = SinA / a")
                                ListBox1.Items.Add("                    Sin (" & C1.Text & ") / " & C2.Text & " = Sin (" & A1.Text & ") / a")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & " / " & C2.Text & " = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) & " / b")))))
                                ListBox1.Items.Add("                    Cross Multiply")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & " * b = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) & " * " & C2.Text)))))
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & "b = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(C2.Text))))))
                                ListBox1.Items.Add("                    a = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(C2.Text))) & " / " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951))))
                                ListBox1.Items.Add("          Therefore; a = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(C2.Text))) / (CStr(Math.Sin(Val(C1.Text) / 57.29577951))))
                                A2.Text = (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(C2.Text))) / (CStr(Math.Sin(Val(C1.Text) / 57.29577951)))
                            End If
                        End If
                    End If
                End If
            End If
            If A2.Text <> "" Then
                If B2.Text <> "" Then
                    If C2.Text <> "" Then
                        If ListBox1.Items.Count < 1 Then
                            ListBox1.Items.Add("______________________________________________________________________________________________________________________")
                            ListBox1.Items.Add("          Using Cosine Rule;")
                            ListBox1.Items.Add("                    c^2 = a^2 + b^2 - 2ab * CosC")
                            ListBox1.Items.Add("                    (" & C2.Text & ")^2 = (" & A2.Text & ")^2 + (" & B2.Text & ")^2 - 2 * " & A2.Text & " * " & B2.Text & " * CosC")
                            ListBox1.Items.Add("                    " & Val(C2.Text) ^ 2 & " = " & Val(A2.Text) ^ 2 & " + " & Val(B2.Text) ^ 2 & " - " & 2 * Val(A2.Text) * Val(B2.Text) & "CosC")
                            ListBox1.Items.Add("                    " & Val(C2.Text) ^ 2 & " = " & (Val(A2.Text) ^ 2) + (Val(B2.Text) ^ 2) & " - " & 2 * Val(A2.Text) * Val(B2.Text) & "CosC")
                            ListBox1.Items.Add("                    " & 2 * Val(A2.Text) * Val(B2.Text) & "CosC = " & (Val(A2.Text) ^ 2) + (Val(B2.Text) ^ 2) & " - " & Val(C2.Text) ^ 2)
                            ListBox1.Items.Add("                    CosC = " & ((Val(A2.Text) ^ 2) + (Val(B2.Text) ^ 2)) - (Val(C2.Text) ^ 2) & " / " & 2 * Val(A2.Text) * Val(B2.Text))
                            ListBox1.Items.Add("                    CosC = " & (((Val(A2.Text) ^ 2) + (Val(B2.Text) ^ 2)) - (Val(C2.Text) ^ 2)) / (2 * Val(A2.Text) * Val(B2.Text)))
                            ListBox1.Items.Add("                       C = Cos-1 (" & (((Val(A2.Text) ^ 2) + (Val(B2.Text) ^ 2)) - (Val(C2.Text) ^ 2)) / (2 * Val(A2.Text) * Val(B2.Text)) & ")")
                            Dim x As Double = (((Val(A2.Text) ^ 2) + (Val(B2.Text) ^ 2)) - (Val(C2.Text) ^ 2)) / (2 * Val(A2.Text) * Val(B2.Text))
                            ListBox1.Items.Add("                       C = " & CStr(Math.Acos(x)) * 57.29577951)
                            ListBox1.Items.Add("            Therefore; C = " & CStr(Math.Acos(x)) * 57.29577951)
                            C1.Text = CStr(Math.Acos(x)) * 57.29577951
                        End If
                        If A1.Text = "" Then
                            ListBox1.Items.Add("")
                            ListBox1.Items.Add("          Using Sine Rule;")
                            ListBox1.Items.Add("                    SinC / c = SinA / a")
                            ListBox1.Items.Add("                    Sin (" & C1.Text & ") / " & C2.Text & " = SinA / " & Val(A2.Text))
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & " / " & C2.Text & " = SinA / " & Val(A2.Text))))
                            ListBox1.Items.Add("                    Cross Multiply")
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & " * " & Val(A2.Text) & " = SinA * " & C2.Text)))
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) * Val(A2.Text) & " = " & Val(C2.Text) & "SinA")))
                            ListBox1.Items.Add("                    SinA = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(A2.Text))) & " / " & (Val(C2.Text)))
                            ListBox1.Items.Add("                    SinA = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(A2.Text))) / (Val(C2.Text)))
                            ListBox1.Items.Add("                       A = " & "Sin-1 (" & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(A2.Text))) / Val(C2.Text) & ")")
                            Dim B As Double = ((CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(A2.Text))) / Val(C2.Text))
                            ListBox1.Items.Add("                       A = " & CStr(Math.Asin(B)) * 57.29577951)
                            ListBox1.Items.Add("          Therefore;   A = " & CStr(Math.Asin(B)) * 57.29577951)
                            A1.Text = CStr(Math.Asin(B) * 57.29577951)
                        End If
                        If B1.Text = "" Then
                            ListBox1.Items.Add("")
                            ListBox1.Items.Add("                    B = 180 - (" & C1.Text & " + " & A1.Text & ") -          Sum of angles in a triangle")
                            ListBox1.Items.Add("                    B = 180 - (" & Val(C1.Text) + Val(A1.Text) & ")")
                            ListBox1.Items.Add("                    B = " & 180 - (Val(C1.Text) + Val(A1.Text)))
                            ListBox1.Items.Add("          Therefore; B = " & 180 - (Val(C1.Text) + Val(A1.Text)))
                            B1.Text = 180 - (Val(C1.Text) + Val(A1.Text))
                        End If
                    End If
                End If
            End If
            If ListBox1.Items.Count < 1 Then
                If A2.Text <> "" Then
                    If B2.Text <> "" Then
                        If C1.Text <> "" Then
                            ListBox1.Items.Add("______________________________________________________________________________________________________________________")
                            ListBox1.Items.Add("          Using Cosine Rule;")
                            ListBox1.Items.Add("                    c^2 = a^2 + b^2 - 2ab * CosC")
                            ListBox1.Items.Add("                    c^2 = (" & A2.Text & ")^2 + (" & B2.Text & ")^2 - 2 * " & A2.Text & " * " & B2.Text & " * Cos (" & C1.Text & ")")
                            ListBox1.Items.Add("                    c^2 = " & (Val(A2.Text) ^ 2) + (Val(B2.Text) ^ 2) & "" & -2 * (Val(A2.Text) * Val(B2.Text)) * CStr(Math.Cos(Val(C1.Text) / 57.29577951)))
                            ListBox1.Items.Add("                    c^2 = " & ((Val(A2.Text) ^ 2) + (Val(B2.Text) ^ 2)) - 2 * (Val(A2.Text) * Val(B2.Text)) * CStr(Math.Cos(Val(C1.Text) / 57.29577951)))
                            ListBox1.Items.Add("          Square Root Both sides;")
                            ListBox1.Items.Add("                      c = SQRT (" & ((Val(A2.Text) ^ 2) + (Val(B2.Text) ^ 2)) - 2 * (Val(A2.Text) * Val(B2.Text)) * CStr(Math.Cos(Val(C1.Text) / 57.29577951)) & ")")
                            ListBox1.Items.Add("                      c = " & CStr(Math.Sqrt(((Val(A2.Text) ^ 2) + (Val(B2.Text) ^ 2)) - 2 * (Val(A2.Text) * Val(B2.Text)) * CStr(Math.Cos(Val(C1.Text) / 57.29577951)))))
                            ListBox1.Items.Add("           Therefore; c = " & CStr(Math.Sqrt(((Val(A2.Text) ^ 2) + (Val(B2.Text) ^ 2)) - 2 * (Val(A2.Text) * Val(B2.Text)) * CStr(Math.Cos(Val(C1.Text) / 57.29577951)))))
                            C2.Text = CStr(Math.Sqrt(((Val(A2.Text) ^ 2) + (Val(B2.Text) ^ 2)) - 2 * (Val(A2.Text) * Val(B2.Text)) * CStr(Math.Cos(Val(C1.Text) / 57.29577951))))
                            If B1.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("          Using Sine Rule;")
                                ListBox1.Items.Add("                    SinC / c = SinB / b")
                                ListBox1.Items.Add("                    Sin (" & C1.Text & ") / " & C2.Text & " = SinB / " & Val(B2.Text))
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & " / " & C2.Text & " = SinB / " & Val(B2.Text))))
                                ListBox1.Items.Add("                    Cross Multiply")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) & " * " & Val(B2.Text) & " = SinB * " & C2.Text)))
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(C1.Text) / 57.29577951) * Val(B2.Text) & " = " & Val(C2.Text) & "SinB")))
                                ListBox1.Items.Add("                    SinB = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(B2.Text))) & " / " & (Val(C2.Text)))
                                ListBox1.Items.Add("                    SinB = " & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(B2.Text))) / (Val(C2.Text)))
                                ListBox1.Items.Add("                       B = " & "Sin-1 (" & (CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(B2.Text))) / Val(C2.Text) & ")")
                                Dim B As Double = ((CStr(Math.Sin(Val(C1.Text) / (57.29577951)) * Val(B2.Text))) / Val(C2.Text))
                                ListBox1.Items.Add("                       B = " & CStr(Math.Asin(B)) * 57.29577951)
                                ListBox1.Items.Add("          Therefore;   B = " & CStr(Math.Asin(B)) * 57.29577951)
                                B1.Text = CStr(Math.Asin(B) * 57.29577951)
                            End If
                            If A1.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("                    A = 180 - (" & C1.Text & " + " & B1.Text & ") -          Sum of angles in a triangle")
                                ListBox1.Items.Add("                    A = 180 - (" & Val(C1.Text) + Val(B1.Text) & ")")
                                ListBox1.Items.Add("                    A = " & 180 - (Val(C1.Text) + Val(B1.Text)))
                                ListBox1.Items.Add("          Therefore; A = " & 180 - (Val(C1.Text) + Val(B1.Text)))
                                A1.Text = 180 - (Val(C1.Text) + Val(B1.Text))
                            End If
                        End If
                    End If
                End If
            End If
            If ListBox1.Items.Count < 1 Then
                If B2.Text <> "" Then
                    If C2.Text <> "" Then
                        If A1.Text <> "" Then
                            ListBox1.Items.Add("______________________________________________________________________________________________________________________")
                            ListBox1.Items.Add("          Using Cosine Rule;")
                            ListBox1.Items.Add("                    a^2 = b^2 + c^2 - 2bc * CosA")
                            ListBox1.Items.Add("                    a^2 = (" & B2.Text & ")^2 + (" & C2.Text & ")^2 - 2 * " & B2.Text & " * " & C2.Text & " * Cos (" & A1.Text & ")")
                            ListBox1.Items.Add("                    a^2 = " & (Val(B2.Text) ^ 2) + (Val(C2.Text) ^ 2) & "" & -2 * (Val(B2.Text) * Val(C2.Text)) * CStr(Math.Cos(Val(A1.Text) / 57.29577951)))
                            ListBox1.Items.Add("                    a^2 = " & ((Val(B2.Text) ^ 2) + (Val(C2.Text) ^ 2)) - 2 * (Val(B2.Text) * Val(C2.Text)) * CStr(Math.Cos(Val(A1.Text) / 57.29577951)))
                            ListBox1.Items.Add("          Square Root Both sides;")
                            ListBox1.Items.Add("                      a = SQRT (" & ((Val(B2.Text) ^ 2) + (Val(C2.Text) ^ 2)) - 2 * (Val(B2.Text) * Val(C2.Text)) * CStr(Math.Cos(Val(A1.Text) / 57.29577951)) & ")")
                            ListBox1.Items.Add("                      a = " & CStr(Math.Sqrt(((Val(B2.Text) ^ 2) + (Val(C2.Text) ^ 2)) - 2 * (Val(B2.Text) * Val(C2.Text)) * CStr(Math.Cos(Val(A1.Text) / 57.29577951)))))
                            ListBox1.Items.Add("           Therefore; a = " & CStr(Math.Sqrt(((Val(B2.Text) ^ 2) + (Val(C2.Text) ^ 2)) - 2 * (Val(B2.Text) * Val(C2.Text)) * CStr(Math.Cos(Val(A1.Text) / 57.29577951)))))
                            A2.Text = CStr(Math.Sqrt(((Val(B2.Text) ^ 2) + (Val(C2.Text) ^ 2)) - 2 * (Val(B2.Text) * Val(C2.Text)) * CStr(Math.Cos(Val(A1.Text) / 57.29577951))))
                            If C1.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("          Using Sine Rule;")
                                ListBox1.Items.Add("                    SinA / a = SinC / c")
                                ListBox1.Items.Add("                    Sin (" & A1.Text & ") / " & A2.Text & " = SinC / " & Val(C2.Text))
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & " / " & A2.Text & " = SinC / " & Val(C2.Text))))
                                ListBox1.Items.Add("                    Cross Multiply")
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) & " * " & Val(C2.Text) & " = SinC * " & A2.Text)))
                                ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(A1.Text) / 57.29577951) * Val(C2.Text) & " = " & Val(A2.Text) & "SinC")))
                                ListBox1.Items.Add("                    SinC = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(C2.Text))) & " / " & (Val(A2.Text)))
                                ListBox1.Items.Add("                    SinC = " & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(C2.Text))) / (Val(A2.Text)))
                                ListBox1.Items.Add("                       C = " & "Sin-1 (" & (CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(C2.Text))) / Val(A2.Text) & ")")
                                Dim B As Double = ((CStr(Math.Sin(Val(A1.Text) / (57.29577951)) * Val(C2.Text))) / Val(A2.Text))
                                ListBox1.Items.Add("                       C = " & CStr(Math.Asin(B)) * 57.29577951)
                                ListBox1.Items.Add("          Therefore;   C = " & CStr(Math.Asin(B)) * 57.29577951)
                                C1.Text = CStr(Math.Asin(B) * 57.29577951)
                            End If
                            If B1.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("                    B = 180 - (" & C1.Text & " + " & A1.Text & ") -          Sum of angles in a triangle")
                                ListBox1.Items.Add("                    B = 180 - (" & Val(C1.Text) + Val(A1.Text) & ")")
                                ListBox1.Items.Add("                    B = " & 180 - (Val(C1.Text) + Val(A1.Text)))
                                ListBox1.Items.Add("          Therefore; B = " & 180 - (Val(C1.Text) + Val(A1.Text)))
                                B1.Text = 180 - (Val(C1.Text) + Val(A1.Text))
                            End If
                        End If
                    End If
                End If
            End If
            If ListBox1.Items.Count < 1 Then
                If A2.Text <> "" Then
                    If C2.Text <> "" Then
                        If B1.Text <> "" Then
                            ListBox1.Items.Add("______________________________________________________________________________________________________________________")
                            ListBox1.Items.Add("          Using Cosine Rule;")
                            ListBox1.Items.Add("                    b^2 = a^2 + c^2 - 2ac * CosB")
                            ListBox1.Items.Add("                    b^2 = (" & A2.Text & ")^2 + (" & C2.Text & ")^2 - 2 * " & A2.Text & " * " & C2.Text & " * Cos (" & A1.Text & ")")
                            ListBox1.Items.Add("                    b^2 = " & (Val(A2.Text) ^ 2) + (Val(C2.Text) ^ 2) & "" & -2 * (Val(A2.Text) * Val(C2.Text)) * CStr(Math.Cos(Val(A1.Text) / 57.29577951)))
                            ListBox1.Items.Add("                    b^2 = " & ((Val(A2.Text) ^ 2) + (Val(C2.Text) ^ 2)) - 2 * (Val(A2.Text) * Val(C2.Text)) * CStr(Math.Cos(Val(A1.Text) / 57.29577951)))
                            ListBox1.Items.Add("          Square Root Both sides;")
                            ListBox1.Items.Add("                      b = SQRT (" & ((Val(A2.Text) ^ 2) + (Val(C2.Text) ^ 2)) - 2 * (Val(A2.Text) * Val(C2.Text)) * CStr(Math.Cos(Val(A1.Text) / 57.29577951)) & ")")
                            ListBox1.Items.Add("                      b = " & CStr(Math.Sqrt(((Val(A2.Text) ^ 2) + (Val(C2.Text) ^ 2)) - 2 * (Val(A2.Text) * Val(C2.Text)) * CStr(Math.Cos(Val(A1.Text) / 57.29577951)))))
                            ListBox1.Items.Add("           Therefore; b = " & CStr(Math.Sqrt(((Val(A2.Text) ^ 2) + (Val(C2.Text) ^ 2)) - 2 * (Val(A2.Text) * Val(C2.Text)) * CStr(Math.Cos(Val(A1.Text) / 57.29577951)))))
                            B2.Text = CStr(Math.Sqrt(((Val(A2.Text) ^ 2) + (Val(C2.Text) ^ 2)) - 2 * (Val(A2.Text) * Val(C2.Text)) * CStr(Math.Cos(Val(A1.Text) / 57.29577951))))
                        End If
                        If C1.Text = "" Then
                            ListBox1.Items.Add("")
                            ListBox1.Items.Add("          Using Sine Rule;")
                            ListBox1.Items.Add("                    SinB / b = SinC / c")
                            ListBox1.Items.Add("                    Sin (" & B1.Text & ") / " & B2.Text & " = SinC / " & Val(C2.Text))
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & " / " & B2.Text & " = SinC / " & Val(C2.Text))))
                            ListBox1.Items.Add("                    Cross Multiply")
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) & " * " & Val(C2.Text) & " = SinC * " & B2.Text)))
                            ListBox1.Items.Add("                    " & (CStr(Math.Sin(Val(B1.Text) / 57.29577951) * Val(C2.Text) & " = " & Val(B2.Text) & "SinC")))
                            ListBox1.Items.Add("                    SinC = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(C2.Text))) & " / " & (Val(B2.Text)))
                            ListBox1.Items.Add("                    SinC = " & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(C2.Text))) / (Val(B2.Text)))
                            ListBox1.Items.Add("                       C = " & "Sin-1 (" & (CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(C2.Text))) / Val(B2.Text) & ")")
                            Dim B As Double = ((CStr(Math.Sin(Val(B1.Text) / (57.29577951)) * Val(C2.Text))) / Val(B2.Text))
                            ListBox1.Items.Add("                       C = " & CStr(Math.Asin(B)) * 57.29577951)
                            ListBox1.Items.Add("          Therefore;   C = " & CStr(Math.Asin(B)) * 57.29577951)
                            C1.Text = CStr(Math.Asin(B) * 57.29577951)
                        End If
                        If A1.Text = "" Then
                            If A1.Text = "" Then
                                ListBox1.Items.Add("")
                                ListBox1.Items.Add("                    A = 180 - (" & C1.Text & " + " & B1.Text & ") -          Sum of angles in a triangle")
                                ListBox1.Items.Add("                    A = 180 - (" & Val(C1.Text) + Val(B1.Text) & ")")
                                ListBox1.Items.Add("                    A = " & 180 - (Val(C1.Text) + Val(B1.Text)))
                                ListBox1.Items.Add("          Therefore; A = " & 180 - (Val(C1.Text) + Val(B1.Text)))
                                A1.Text = 180 - (Val(C1.Text) + Val(B1.Text))
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ListBox1.Items.Count >= 1 Then
            Dim ctl As Control
            For Each ctl In Controls
                If TypeOf ctl Is TextBox Then
                    ctl.Text = CStr(Math.Round(Val(ctl.Text), 4))
                End If
            Next
        End If
        t = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next
        ListBox1.Items.Clear()
    End Sub
End Class