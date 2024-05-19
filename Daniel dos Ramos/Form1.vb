Public Class Form1
    Private LabelMin As Object

    Private Sub btnInformation_Click(sender As Object, e As EventArgs) Handles btnInformation.Click
        MessageBox.Show("Instructies : 1. Vul de begin - en eindstand in 2. Kies de fase uit  3. Klik op Bereken voor het Totale . Als de kosten boven SRD 200,- is gaat het textvakje van totaal rood gekleurd zijn en  er gaat een waarschuwingsgeluid te horen zijn. ",
    "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
    End Sub



    Private Sub ComboBoxFase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFase.SelectedIndexChanged
        Dim lblFase As String = ComboBoxFase.Text
        Dim lblFaseB As String

        lblFaseB = 10 And 20 AndAlso 30

        Select Case lblFase

            Case "1"
                lblFaseB = "10"
            Case "2"
                lblFaseB = "20"
            Case "3"
                lblFaseB = "30"

        End Select

        LabelFasebedrag.Text = lblFaseB
        ComboBoxFase.SelectAll()

    End Sub
    Private Sub btnbereken_Click(sender As Object, e As EventArgs) Handles btnbereken.Click
        Labelverbruikers.Text = Val(Txteind.Text) - Val(Txtbegin.Text)
        LabelRekening.Text = Val(Labelverbruikers.Text) * Val(0.15)
        LabelTotaal.Text = Val(Labelverbruikers.Text * 0.15) + Val(LabelFasebedrag.Text)

        If LabelTotaal.Text > 200 Then
            LabelTotaal.BackColor = Color.Red

            System.Media.SystemSounds.Asterisk.Play()

            MessageBox.Show("Waarschuwing : De tekstbox is rood , omdat de kosten boven de SRD 200,- is ! ",
 "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        Else
            LabelTotaal.BackColor = Color.Orchid

        End If


    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Txtbegin.Clear()
        Txteind.Clear()
        ComboBoxFase.Text = ""
        Labelverbruikers.Text = ""
        LabelRekening.Text = ""
        LabelFasebedrag.Text = ""
        LabelTotaal.Text = ""
        LabelTotaal.BackColor = Color.Orchid




    End Sub

    Private Sub btnsluiten_Click(sender As Object, e As EventArgs) Handles btnsluiten.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelTime.Text = Format(Now, "yyyy-MM-dd ")
    End Sub
End Class
