Public Class Form1
    Dim add, subt, mul, div, sqr, result, oprloop, addloop, subtloop, mulloop, divloop, len1, len2, del As Integer
    Dim add_aft_mul, add_aft_subt, add_aft_div, subt_aft_add, subt_aft_mul, subt_aft_div As Integer
    Dim mul_aft_add, mul_aft_subt, mul_aft_div, div_aft_add, div_aft_subt, div_aft_mul As Integer
    Dim sqr_aft_add, sqr_aft_subt, sqr_aft_mul, sqr_aft_div, sqrloop As Integer
    Dim add_aft_sqr, subt_aft_sqr, mul_aft_sqr, div_aft_sqr As Integer
    Dim opr1, opr2, answer As Double
    Dim opr, del_opr1, del_opr2 As String
    Dim mark As Integer
    Dim stk As Stack
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If result Then
            clear()
            result = False
        End If

        TextBox1.Text = TextBox1.Text + Button9.Text
        If add Then
            TextBox2.Text = Button9.Text
            add = False

        ElseIf subt Then
            TextBox2.Text = Button9.Text
            subt = False
        ElseIf mul Then
            TextBox2.Text = Button9.Text
            mul = False

        ElseIf div Then
            TextBox2.Text = Button9.Text
            div = False

        ElseIf sqr Then
            TextBox2.Text = Button9.Text
            sqr = False

        Else
            TextBox2.Text = TextBox2.Text + Button9.Text
        End If
        opr1 = Val(TextBox2.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If result Then
            clear()
            result = False
        End If

        TextBox1.Text = TextBox1.Text + Button1.Text
        If add Then
            TextBox2.Text = Button1.Text
            add = False

        ElseIf subt Then
            TextBox2.Text = Button1.Text
            subt = False

        ElseIf mul Then
            TextBox2.Text = Button1.Text
            mul = False

        ElseIf div Then
            TextBox2.Text = Button1.Text
            div = False

        ElseIf sqr Then
            TextBox2.Text = Button1.Text
            sqr = False

        Else
            TextBox2.Text = TextBox2.Text + Button1.Text
        End If
        opr1 = Val(TextBox2.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If result Then
            clear()
            result = False
        End If

        TextBox1.Text = TextBox1.Text + Button2.Text
        If add Then
            TextBox2.Text = Button2.Text
            add = False

        ElseIf subt Then
            TextBox2.Text = Button2.Text
            subt = False

        ElseIf mul Then
            TextBox2.Text = Button2.Text
            mul = False

        ElseIf div Then
            TextBox2.Text = Button2.Text
            div = False

        ElseIf sqr Then
            TextBox2.Text = Button2.Text
            sqr = False

        Else
            TextBox2.Text = TextBox2.Text + Button2.Text
        End If
        opr1 = Val(TextBox2.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If result Then
            clear()
            result = False
        End If

        TextBox1.Text = TextBox1.Text + Button3.Text
        If add Then
            TextBox2.Text = Button3.Text
            add = False

        ElseIf subt Then
            TextBox2.Text = Button3.Text
            subt = False

        ElseIf mul Then
            TextBox2.Text = Button3.Text
            mul = False

        ElseIf div Then
            TextBox2.Text = Button3.Text
            div = False

        ElseIf sqr Then
            TextBox2.Text = Button3.Text
            sqr = False

        Else
            TextBox2.Text = TextBox2.Text + Button3.Text
        End If
        opr1 = Val(TextBox2.Text)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If result Then
            clear()
            result = False
        End If

        TextBox1.Text = TextBox1.Text + Button4.Text
        If add Then
            TextBox2.Text = Button4.Text
            add = False

        ElseIf subt Then
            TextBox2.Text = Button4.Text
            subt = False

        ElseIf mul Then
            TextBox2.Text = Button4.Text
            mul = False

        ElseIf div Then
            TextBox2.Text = Button4.Text
            div = False

        ElseIf sqr Then
            TextBox2.Text = Button4.Text
            sqr = False

        Else
            TextBox2.Text = TextBox2.Text + Button4.Text
        End If
        opr1 = Val(TextBox2.Text)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If result Then
            clear()
            result = False
        End If

        TextBox1.Text = TextBox1.Text + Button5.Text
        If add Then
            TextBox2.Text = Button5.Text
            add = False

        ElseIf subt Then
            TextBox2.Text = Button5.Text
            subt = False

        ElseIf mul Then
            TextBox2.Text = Button5.Text
            mul = False

        ElseIf div Then
            TextBox2.Text = Button5.Text
            div = False

        ElseIf sqr Then
            TextBox2.Text = Button5.Text
            sqr = False

        Else
            TextBox2.Text = TextBox2.Text + Button5.Text
        End If
        opr1 = Val(TextBox2.Text)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If result Then
            clear()
            result = False
        End If

        TextBox1.Text = TextBox1.Text + Button6.Text
        If add Then
            TextBox2.Text = Button6.Text
            add = False

        ElseIf subt Then
            TextBox2.Text = Button6.Text
            subt = False

        ElseIf mul Then
            TextBox2.Text = Button6.Text
            mul = False

        ElseIf div Then
            TextBox2.Text = Button6.Text
            div = False

        ElseIf sqr Then
            TextBox2.Text = Button6.Text
            sqr = False

        Else
            TextBox2.Text = TextBox2.Text + Button6.Text
        End If
        opr1 = Val(TextBox2.Text)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If result Then
            clear()
            result = False
        End If

        TextBox1.Text = TextBox1.Text + Button7.Text
        If add Then
            TextBox2.Text = Button7.Text
            add = False

        ElseIf subt Then
            TextBox2.Text = Button7.Text
            subt = False

        ElseIf mul Then
            TextBox2.Text = Button7.Text
            mul = False

        ElseIf div Then
            TextBox2.Text = Button7.Text
            div = False

        ElseIf sqr Then
            TextBox2.Text = Button7.Text
            sqr = False

        Else
            TextBox2.Text = TextBox2.Text + Button7.Text
        End If
        opr1 = Val(TextBox2.Text)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If result Then
            clear()
            result = False
        End If

        TextBox1.Text = TextBox1.Text + Button8.Text
        If add Then
            TextBox2.Text = Button8.Text
            add = False

        ElseIf subt Then
            TextBox2.Text = Button8.Text
            subt = False

        ElseIf mul Then
            TextBox2.Text = Button8.Text
            mul = False

        ElseIf div Then
            TextBox2.Text = Button8.Text
            div = False

        ElseIf sqr Then
            TextBox2.Text = Button8.Text
            sqr = False

        Else
            TextBox2.Text = TextBox2.Text + Button8.Text
        End If
        opr1 = Val(TextBox2.Text)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If result Then
            clear()
            result = False
        End If

        TextBox1.Text = TextBox1.Text + Button10.Text
        If add Then
            TextBox2.Text = Button10.Text
            add = False

        ElseIf subt Then
            TextBox2.Text = Button10.Text
            subt = False

        ElseIf mul Then
            TextBox2.Text = Button10.Text
            mul = False

        ElseIf div Then
            TextBox2.Text = Button10.Text
            div = False

        ElseIf sqr Then
            TextBox2.Text = Button10.Text
            sqr = False

        Else
            TextBox2.Text = TextBox2.Text + Button10.Text
        End If
        opr1 = Val(TextBox2.Text)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If result Then
            clear()
            result = False
        End If

        TextBox1.Text = TextBox1.Text + Button11.Text
        If add Then
            TextBox2.Text = Button11.Text
            add = False

        ElseIf subt Then
            TextBox2.Text = Button11.Text
            subt = False

        ElseIf mul Then
            TextBox2.Text = Button11.Text
            mul = False

        ElseIf div Then
            TextBox2.Text = Button11.Text
            div = False

        ElseIf sqr Then
            TextBox2.Text = Button11.Text
            sqr = False

        Else
            TextBox2.Text = TextBox2.Text + Button11.Text
        End If
        opr1 = Val(TextBox2.Text)
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        If add_aft_subt Then
            subtraction()
            add_aft_subt = False
            mul_aft_subt = False
            div_aft_subt = False
            sqr_aft_subt = False

        ElseIf add_aft_mul Then
            multiplication()
            add_aft_mul = False
            subt_aft_mul = False
            div_aft_mul = False
            sqr_aft_mul = False

        ElseIf add_aft_div Then
            division()
            add_aft_div = False
            subt_aft_div = False
            mul_aft_div = False
            sqr_aft_div = False

        ElseIf add_aft_sqr Then
            square()
            add_aft_sqr = False
            subt_aft_sqr = False
            mul_aft_sqr = False
            div_aft_sqr = False

        ElseIf addloop Then
            addition()

        ElseIf addloop = False Then
            opr2 = 0
            answer = opr1 + opr2
            TextBox2.Text = answer

        End If
        add = True
        oprloop = True
        TextBox1.Text = TextBox1.Text & Button18.Text
        opr = "+"
        addloop = True

        subt_aft_add = True
        mul_aft_add = True
        div_aft_add = True
        sqr_aft_add = True
    End Sub
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        If subt_aft_add Then
            addition()
            subt_aft_add = False
            mul_aft_add = False
            div_aft_add = False
            sqr_aft_add = False

        ElseIf subt_aft_mul Then
            multiplication()
            subt_aft_mul = False
            add_aft_mul = False
            div_aft_mul = False
            sqr_aft_mul = False

        ElseIf subt_aft_div Then
            division()
            subt_aft_div = False
            add_aft_div = False
            mul_aft_div = False
            sqr_aft_div = False

        ElseIf subt_aft_sqr Then
            square()
            add_aft_sqr = False
            subt_aft_sqr = False
            mul_aft_sqr = False
            div_aft_sqr = False

        ElseIf subtloop Then
            subtraction()

        ElseIf subtloop = False Then
            opr2 = 0
            answer = opr1 - opr2
            TextBox2.Text = answer
        End If
        subt = True
        oprloop = True
        TextBox1.Text = TextBox1.Text & Button16.Text
        opr = "-"
        subtloop = True

        add_aft_subt = True
        mul_aft_subt = True
        div_aft_subt = True
        sqr_aft_subt = True
    End Sub
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If mul_aft_add Then
            addition()
            mul_aft_add = False
            subt_aft_add = False
            div_aft_add = False
            sqr_aft_add = False

        ElseIf mul_aft_subt Then
            subtraction()
            mul_aft_subt = False
            add_aft_subt = False
            div_aft_subt = False
            sqr_aft_subt = False

        ElseIf mul_aft_div Then
            division()
            mul_aft_div = False
            add_aft_div = False
            subt_aft_div = False
            sqr_aft_div = False

        ElseIf mul_aft_sqr Then
            square()
            add_aft_sqr = False
            subt_aft_sqr = False
            mul_aft_sqr = False
            div_aft_sqr = False

        ElseIf mulloop Then
            multiplication()

        ElseIf mulloop = False Then
            TextBox2.Text = opr1
            answer = opr1
        End If
        mul = True
        oprloop = True
        TextBox1.Text = TextBox1.Text & Button14.Text
        opr = "*"
        mulloop = True

        add_aft_mul = True
        subt_aft_mul = True
        div_aft_mul = True
        sqr_aft_mul = True
    End Sub
    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        If div_aft_add Then
            addition()
            div_aft_add = False
            subt_aft_add = False
            mul_aft_add = False
            sqr_aft_add = False

        ElseIf div_aft_subt Then
            subtraction()
            div_aft_subt = False
            add_aft_subt = False
            mul_aft_subt = False
            sqr_aft_subt = False

        ElseIf div_aft_mul Then
           multiplication()
            div_aft_mul = False
            add_aft_mul = False
            subt_aft_mul = False
            sqr_aft_mul = False

        ElseIf div_aft_sqr Then
            square()
            div_aft_sqr = False
            mul_aft_sqr = False
            subt_aft_sqr = False
            add_aft_sqr = False

        ElseIf divloop Then
            division()

        ElseIf divloop = False Then
            TextBox2.Text = opr1
            answer = opr1
        End If
        div = True
        oprloop = True
        TextBox1.Text = TextBox1.Text & Button19.Text
        opr = "/"
        divloop = True

        add_aft_div = True
        subt_aft_div = True
        mul_aft_div = True
        sqr_aft_div = True
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Clear()

        oprloop = False
        addloop = False
        subtloop = False
        mulloop = False
        divloop = False
        sqrloop = False

        add_aft_subt = False
        add_aft_mul = False
        add_aft_div = False
        add_aft_sqr = False

        subt_aft_add = False
        subt_aft_mul = False
        subt_aft_div = False
        subt_aft_sqr = False

        mul_aft_add = False
        mul_aft_subt = False
        mul_aft_div = False
        mul_aft_sqr = False

        div_aft_add = False
        div_aft_subt = False
        div_aft_mul = False
        div_aft_sqr = False
    End Sub
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        result = True
        Select Case opr
            Case "+"

                If addloop Then
                    addition()

                ElseIf addloop = False Then
                    opr2 = 0
                    answer = opr1 + opr2
                    TextBox2.Text = answer
                End If
                add = True
                oprloop = True
                TextBox1.Text = TextBox1.Text
                opr = "+"
                addloop = True

            Case "-"

                If subtloop Then
                    subtraction()

                ElseIf subtloop = False Then
                    opr2 = 0
                    answer = opr1 - opr2
                    TextBox2.Text = answer
                End If
                subt = True
                oprloop = True
                TextBox1.Text = TextBox1.Text
                opr = "-"
                subtloop = True

            Case "*"
                
                If mulloop Then
                    multiplication()

                ElseIf mulloop = False Then
                    TextBox2.Text = opr1
                    answer = opr1
                End If
                mul = True
                oprloop = True
                TextBox1.Text = TextBox1.Text
                opr = "*"
                mulloop = True

            Case "/"
                
                If divloop Then
                    division()

                ElseIf divloop = False Then
                    TextBox2.Text = opr1
                    answer = opr1
                End If
                div = True
                oprloop = True
                TextBox1.Text = TextBox1.Text
                opr = "/"
                divloop = True

            Case "^"

                If sqrloop Then
                    square()

                ElseIf sqrloop = False Then
                    TextBox2.Text = opr1
                    answer = opr1
                End If
                sqr = True
                oprloop = True
                TextBox1.Text = TextBox1.Text
                opr = "^"
                sqrloop = True
        End Select
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        clear()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If TextBox1.TextLength > 0 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.TextLength - 1, 1)
        End If
        If TextBox2.TextLength > 0 Then
            TextBox2.Text = TextBox2.Text.Remove(TextBox2.TextLength - 1, 1)
        End If
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        If sqr_aft_add Then
            addition()
            mul_aft_add = False
            subt_aft_add = False
            div_aft_add = False
            sqr_aft_add = False

        ElseIf sqr_aft_subt Then
            subtraction()
            mul_aft_subt = False
            add_aft_subt = False
            div_aft_subt = False
            sqr_aft_subt = False

        ElseIf sqr_aft_mul Then
            multiplication()
            add_aft_mul = False
            subt_aft_mul = False
            div_aft_mul = False
            sqr_aft_mul = False

        ElseIf sqr_aft_div Then
            division()
            mul_aft_div = False
            add_aft_div = False
            subt_aft_div = False
            sqr_aft_div = False

        ElseIf sqrloop Then
            square()

        ElseIf sqrloop = False Then
            TextBox2.Text = opr1
            answer = opr1
        End If
        sqr = True
        oprloop = True
        TextBox1.Text = "(" & TextBox1.Text & "^2" & ")"
        opr = "^"
        sqrloop = True

        add_aft_sqr = True
        subt_aft_sqr = True
        mul_aft_sqr = True
        div_aft_sqr = True
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click

    End Sub
    Private Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        opr1 = 0
        opr2 = 0
        answer = 0

        oprloop = False
        addloop = False
        subtloop = False
        mulloop = False
        divloop = False
        sqrloop = False

        add_aft_subt = False
        add_aft_mul = False
        add_aft_div = False
        add_aft_sqr = False

        subt_aft_add = False
        subt_aft_mul = False
        subt_aft_div = False
        subt_aft_sqr = False

        mul_aft_add = False
        mul_aft_subt = False
        mul_aft_div = False
        mul_aft_sqr = False

        div_aft_add = False
        div_aft_subt = False
        div_aft_mul = False
        div_aft_sqr = False

        sqr_aft_add = False
        sqr_aft_subt = False
        sqr_aft_mul = False
        sqr_aft_div = False
    End Sub

    Private Sub addition()
        opr2 = Val(TextBox2.Text)
        answer = answer + opr2
        TextBox2.Text = answer
    End Sub

    Private Sub subtraction()
        opr2 = Val(TextBox2.Text)
        answer = answer - opr2
        TextBox2.Text = answer
    End Sub

    Private Sub multiplication()
        opr2 = Val(TextBox2.Text)
        answer = answer * opr2
        TextBox2.Text = answer
    End Sub

    Private Sub division()
        opr2 = Val(TextBox2.Text)
        answer = answer / opr2
        TextBox2.Text = answer
    End Sub

    Private Sub square()
        opr2 = Val(TextBox2.Text)
        answer = answer * answer
        TextBox2.Text = answer
    End Sub
End Class
