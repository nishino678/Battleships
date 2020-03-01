Public Class Form1
    Dim speelveld(15) As Boolean
    Dim i As Integer
    Dim teller As Integer = 4
    Dim schepengeplaatst As Integer = 0
    Dim schepengeplaatst2 As Integer
    Dim raak As Integer = 0
    'WIM FRANKENA
    'BIM/ITSM 2
    '306355
    'FRAN@STUDENT.NHL.NL
    '10-02-2016

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        While i < 16
            speelveld(i) = False
            i = i + 1
        End While
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Knop om boten te plaatsen
        MessageBox.Show("Plaats uw schepen")
        teller = 0
    End Sub

    Private Sub A1_Click(sender As Object, e As EventArgs) Handles A1.Click
        'Picturebox A1 (linkerbovenhoek).
        'Het aantal boten word door middel van een teller bijgehouden, komt deze op 4 te staan komt er een messagebox.
        'Hierin staat dat de gebruiker geen boten meer kan plaatsen en op de knop Vuren kan klikken.
        'Verder worden de geplaatse boten blauw gemarkeerd en bijgehouden in een Array
        'Als de gebruiker 4x raak geschoten heeft komt er een melding dat hij gewonnen heeft.
        'Alle pictureboxes zijn hetzelfde gecodeerd.
        If teller < 4 Then
            If speelveld(0) = False Then
                A1.BackColor = Color.Blue
                speelveld(0) = True
                teller = teller + 1
            Else
                teller = teller - 1
                speelveld(0) = False
                A1.BackColor = Color.White
            End If
        ElseIf schepengeplaatst2 = 0 Then
            MessageBox.Show("U heeft al 4 schepen geplaatst! Klik op de knop Vuren")
            schepengeplaatst = 1
        Else
        End If
        If schepengeplaatst2 = 1 Then

            If speelveld(0) Then
                A1.BackColor = Color.Red
                raak = raak + 1
                MessageBox.Show("Raak!")
                If raak = 4 Then
                    MessageBox.Show("U hebt 4 boten vernietigd en gewonnen!")
                End If
            Else A1.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub A2_Click(sender As Object, e As EventArgs) Handles A2.Click
        If teller < 4 Then
            If speelveld(1) = False Then
                A2.BackColor = Color.Blue
                speelveld(1) = True
                teller = teller + 1
            Else
                teller = teller - 1
                speelveld(1) = False
                A2.BackColor = Color.White
            End If
        ElseIf schepengeplaatst2 = 0 Then
            MessageBox.Show("U heeft al 4 schepen geplaatst! Klik op de knop Vuren")
            schepengeplaatst = 1
        End If
        If schepengeplaatst2 = 1 Then

            If speelveld(1) Then
                A2.BackColor = Color.Red
                raak = raak + 1
                MessageBox.Show("Raak!")
                If raak = 4 Then
                    MessageBox.Show("U hebt 4 boten vernietigd en gewonnen!")
                End If
            Else A2.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub A3_Click(sender As Object, e As EventArgs) Handles A3.Click
        If teller < 4 Then
            If speelveld(2) = False Then
                A3.BackColor = Color.Blue
                speelveld(2) = True
                teller = teller + 1
            Else
                teller = teller - 1
                speelveld(2) = False
                A3.BackColor = Color.White
            End If
        ElseIf schepengeplaatst2 = 0 Then
            MessageBox.Show("U heeft al 4 schepen geplaatst! Klik op de knop Vuren")
            schepengeplaatst = 1
        End If
        If schepengeplaatst2 = 1 Then

            If speelveld(2) Then
                A3.BackColor = Color.Red
                raak = raak + 1
                MessageBox.Show("Raak!")
                If raak = 4 Then
                    MessageBox.Show("U hebt 4 boten vernietigd en gewonnen!")
                End If
            Else A3.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub A4_Click(sender As Object, e As EventArgs) Handles A4.Click
        If teller < 4 Then
            If speelveld(3) = False Then
                A4.BackColor = Color.Blue
                speelveld(3) = True
                teller = teller + 1
            Else
                teller = teller - 1
                speelveld(3) = False
                A4.BackColor = Color.White
            End If
        ElseIf schepengeplaatst2 = 0 Then
            MessageBox.Show("U heeft al 4 schepen geplaatst! Klik op de knop Vuren")
            schepengeplaatst = 1
        End If
        If schepengeplaatst2 = 1 Then

            If speelveld(3) Then
                A4.BackColor = Color.Red
                raak = raak + 1
                MessageBox.Show("Raak!")
                If raak = 4 Then
                    MessageBox.Show("U hebt 4 boten vernietigd en gewonnen!")
                End If
            Else A4.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub A5_Click(sender As Object, e As EventArgs) Handles A5.Click
        If teller < 4 Then
            If speelveld(4) = False Then
                A5.BackColor = Color.Blue
                speelveld(4) = True
                teller = teller + 1
            Else
                teller = teller - 1
                speelveld(4) = False
                A5.BackColor = Color.White
            End If
        ElseIf schepengeplaatst2 = 0 Then
            MessageBox.Show("U heeft al 4 schepen geplaatst! Klik op de knop Vuren")
            schepengeplaatst = 1
        End If
        If schepengeplaatst2 = 1 Then

            If speelveld(4) Then
                A5.BackColor = Color.Red
                raak = raak + 1
                MessageBox.Show("Raak!")
                If raak = 4 Then
                    MessageBox.Show("U hebt 4 boten vernietigd en gewonnen!")
                End If
            Else A5.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub A6_Click(sender As Object, e As EventArgs) Handles A6.Click
        If teller < 4 Then
            If speelveld(5) = False Then
                A6.BackColor = Color.Blue
                speelveld(5) = True
                teller = teller + 1
            Else
                teller = teller - 1
                speelveld(5) = False
                A6.BackColor = Color.White
            End If
        ElseIf schepengeplaatst2 = 0 Then
            MessageBox.Show("U heeft al 4 schepen geplaatst! Klik op de knop Vuren")
            schepengeplaatst = 1
        End If
        If schepengeplaatst2 = 1 Then

            If speelveld(5) Then
                A6.BackColor = Color.Red
                raak = raak + 1
                MessageBox.Show("Raak!")
                If raak = 4 Then
                    MessageBox.Show("U hebt 4 boten vernietigd en gewonnen!")
                End If
            Else A6.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub A7_Click(sender As Object, e As EventArgs) Handles A7.Click
        If teller < 4 Then
            If speelveld(6) = False Then
                A7.BackColor = Color.Blue
                speelveld(6) = True
                teller = teller + 1
            Else
                teller = teller - 1
                speelveld(6) = False
                A7.BackColor = Color.White
            End If
        ElseIf schepengeplaatst2 = 0 Then
            MessageBox.Show("U heeft al 4 schepen geplaatst! Klik op de knop Vuren")
            schepengeplaatst = 1
        End If
        If schepengeplaatst2 = 1 Then

            If speelveld(6) Then
                A7.BackColor = Color.Red
                raak = raak + 1
                MessageBox.Show("Raak!")
                If raak = 4 Then
                    MessageBox.Show("U hebt 4 boten vernietigd en gewonnen!")
                End If
            Else A7.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub A8_Click(sender As Object, e As EventArgs) Handles A8.Click
        If teller < 4 Then
            If speelveld(7) = False Then
                A8.BackColor = Color.Blue
                speelveld(7) = True
                teller = teller + 1
            Else
                teller = teller - 1
                speelveld(7) = False
                A8.BackColor = Color.White
            End If
        ElseIf schepengeplaatst2 = 0 Then
            MessageBox.Show("U heeft al 4 schepen geplaatst! Klik op de knop Vuren")
            schepengeplaatst = 1
        End If
        If schepengeplaatst2 = 1 Then

            If speelveld(7) Then
                A8.BackColor = Color.Red
                raak = raak + 1
                MessageBox.Show("Raak!")
                If raak = 4 Then
                    MessageBox.Show("U hebt 4 boten vernietigd en gewonnen!")
                End If
            Else A8.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub A9_Click(sender As Object, e As EventArgs) Handles A9.Click
        If teller < 4 Then
            If speelveld(8) = False Then
                A9.BackColor = Color.Blue
                speelveld(8) = True
                teller = teller + 1
            Else
                teller = teller - 1
                speelveld(8) = False
                A9.BackColor = Color.White
            End If
        ElseIf schepengeplaatst2 = 0 Then
            MessageBox.Show("U heeft al 4 schepen geplaatst! Klik op de knop Vuren")
            schepengeplaatst = 1
        End If
        If schepengeplaatst2 = 1 Then

            If speelveld(8) Then
                A9.BackColor = Color.Red
                raak = raak + 1
                MessageBox.Show("Raak!")
                If raak = 4 Then
                    MessageBox.Show("U hebt 4 boten vernietigd en gewonnen!")
                End If
            Else A9.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub A10_Click(sender As Object, e As EventArgs) Handles A10.Click
        If teller < 4 Then
            If speelveld(9) = False Then
                A10.BackColor = Color.Blue
                speelveld(9) = True
                teller = teller + 1
            Else
                teller = teller - 1
                speelveld(9) = False
                A10.BackColor = Color.White
            End If
        ElseIf schepengeplaatst2 = 0 Then
            MessageBox.Show("U heeft al 4 schepen geplaatst! Klik op de knop Vuren")
            schepengeplaatst = 1
        End If
        If schepengeplaatst2 = 1 Then

            If speelveld(9) Then
                A10.BackColor = Color.Red
                raak = raak + 1
                MessageBox.Show("Raak!")
                If raak = 4 Then
                    MessageBox.Show("U hebt 4 boten vernietigd en gewonnen!")
                End If
            Else A10.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub A11_Click(sender As Object, e As EventArgs) Handles A11.Click
        If teller < 4 Then
            If speelveld(10) = False Then
                A11.BackColor = Color.Blue
                speelveld(10) = True
                teller = teller + 1
            Else
                teller = teller - 1
                speelveld(10) = False
                A11.BackColor = Color.White
            End If
        ElseIf schepengeplaatst2 = 0 Then
            MessageBox.Show("U heeft al 4 schepen geplaatst! Klik op de knop Vuren")
            schepengeplaatst = 1
        End If
        If schepengeplaatst2 = 1 Then

            If speelveld(10) Then
                A11.BackColor = Color.Red
                raak = raak + 1
                MessageBox.Show("Raak!")
                If raak = 4 Then
                    MessageBox.Show("U hebt 4 boten vernietigd en gewonnen!")
                End If
            Else A11.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub A12_Click(sender As Object, e As EventArgs) Handles A12.Click
        If teller < 4 Then
            If speelveld(11) = False Then
                A12.BackColor = Color.Blue
                speelveld(11) = True
                teller = teller + 1
            Else
                teller = teller - 1
                speelveld(11) = False
                A12.BackColor = Color.White
            End If
        ElseIf schepengeplaatst2 = 0 Then
            MessageBox.Show("U heeft al 4 schepen geplaatst! Klik op de knop Vuren")
            schepengeplaatst = 1
        End If
        If schepengeplaatst2 = 1 Then

            If speelveld(11) Then
                A12.BackColor = Color.Red
                raak = raak + 1
                MessageBox.Show("Raak!")
                If raak = 4 Then
                    MessageBox.Show("U hebt 4 boten vernietigd en gewonnen!")
                End If
            Else A12.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub A13_Click(sender As Object, e As EventArgs) Handles A13.Click
        If teller < 4 Then
            If speelveld(12) = False Then
                A13.BackColor = Color.Blue
                speelveld(12) = True
                teller = teller + 1
            Else
                teller = teller - 1
                speelveld(12) = False
                A13.BackColor = Color.White
            End If
        ElseIf schepengeplaatst2 = 0 Then
            MessageBox.Show("U heeft al 4 schepen geplaatst! Klik op de knop Vuren")
            schepengeplaatst = 1
        End If
        If schepengeplaatst2 = 1 Then

            If speelveld(12) Then
                A13.BackColor = Color.Red
                raak = raak + 1
                MessageBox.Show("Raak!")
                If raak = 4 Then
                    MessageBox.Show("U hebt 4 boten vernietigd en gewonnen!")
                End If
            Else A13.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub A14_Click(sender As Object, e As EventArgs) Handles A14.Click
        If teller < 4 Then
            If speelveld(13) = False Then
                A14.BackColor = Color.Blue
                speelveld(13) = True
                teller = teller + 1
            Else
                teller = teller - 1
                speelveld(13) = False
                A14.BackColor = Color.White
            End If
        ElseIf schepengeplaatst2 = 0 Then
            MessageBox.Show("U heeft al 4 schepen geplaatst! Klik op de knop Vuren")
            schepengeplaatst = 1
        End If
        If schepengeplaatst2 = 1 Then

            If speelveld(13) Then
                A14.BackColor = Color.Red
                raak = raak + 1
                MessageBox.Show("Raak!")
                If raak = 4 Then
                    MessageBox.Show("U hebt 4 boten vernietigd en gewonnen!")
                End If
            Else A14.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub A15_Click(sender As Object, e As EventArgs) Handles A15.Click
        If teller < 4 Then
            If speelveld(14) = False Then
                A15.BackColor = Color.Blue
                speelveld(14) = True
                teller = teller + 1
            Else
                teller = teller - 1
                speelveld(14) = False
                A15.BackColor = Color.White
            End If
        ElseIf schepengeplaatst2 = 0 Then
            MessageBox.Show("U heeft al 4 schepen geplaatst! Klik op de knop Vuren")
            schepengeplaatst = 1
        End If
        If schepengeplaatst2 = 1 Then

            If speelveld(14) Then
                A15.BackColor = Color.Red
                raak = raak + 1
                MessageBox.Show("Raak!")
                If raak = 4 Then
                    MessageBox.Show("U hebt 4 boten vernietigd en gewonnen!")
                End If
            Else A15.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub A16_Click(sender As Object, e As EventArgs) Handles A16.Click
        If teller < 4 Then
            If speelveld(15) = False Then
                A16.BackColor = Color.Blue
                speelveld(15) = True
                teller = teller + 1
            Else
                teller = teller - 1
                speelveld(15) = False
                A16.BackColor = Color.White
            End If
        ElseIf schepengeplaatst2 = 0 Then
            MessageBox.Show("U heeft al 4 schepen geplaatst! Klik op de knop Vuren")
            schepengeplaatst = 1
        End If
        If schepengeplaatst2 = 1 Then

            If speelveld(15) Then
                A16.BackColor = Color.Red
                raak = raak + 1
                MessageBox.Show("Raak!")
                If raak = 4 Then
                    MessageBox.Show("U hebt 4 boten vernietigd en gewonnen!")
                End If
            Else A16.BackColor = Color.Black
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Exit knop
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Vuren knop, hiermee word het speelveld weer wit gemaakt zodat de eerder geplaatste boten niet meer zichtbaar zijn.
        'Vervolgens word de voorwaarde schepengeplaatst2 op 1 gezet waardoor de mogelijkheid om te vuren beschikbaar wordt.
        If schepengeplaatst = 1 Then
            A1.BackColor = Color.White
            A2.BackColor = Color.White
            A3.BackColor = Color.White
            A4.BackColor = Color.White
            A5.BackColor = Color.White
            A6.BackColor = Color.White
            A7.BackColor = Color.White
            A8.BackColor = Color.White
            A9.BackColor = Color.White
            A10.BackColor = Color.White
            A11.BackColor = Color.White
            A12.BackColor = Color.White
            A13.BackColor = Color.White
            A14.BackColor = Color.White
            A15.BackColor = Color.White
            A16.BackColor = Color.White
            schepengeplaatst2 = 1
        Else
            MessageBox.Show("Plaats eerst 4 schepen!")
        End If
    End Sub
End Class
