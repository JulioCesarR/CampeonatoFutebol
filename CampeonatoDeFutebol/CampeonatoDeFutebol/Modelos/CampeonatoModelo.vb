Imports CampeonatoDeFutebol

Public Class CampeonatoModelo
    Private cTimes_ As List(Of TimesModelo)


    Public Property CTimes As List(Of TimesModelo)
        Get
            Return cTimes_
        End Get
        Set(value As List(Of TimesModelo))
            cTimes_ = value
        End Set
    End Property
End Class
