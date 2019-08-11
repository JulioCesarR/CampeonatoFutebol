Imports System.Text.RegularExpressions

Module Principal

    Public campeonato As New CampeonatoModelo
    Public times As New List(Of TimesModelo)
    Public NomesTimes = New HashSet(Of String)
    Sub Main()

        Dim s As String = "Flamengo 1 Corinthians 4, Santos 2 Palmeiras 1, Corinthians 3 Santos 1, Palmeiras 0 Flamengo 0, Flamengo 3 Santos 2, Corinthians 4 Palmeiras 1"
        Dim servicos As New CampeonatoServico
        Dim vetpartidas() As String
        s = s.Replace(", ", ",")
        s = s.ToUpper()

        'iniciando os valores dos times informadosna entrada
        servicos.InicializarTimes(s)

        'qubrando as informacoes da string de entrada 
        vetpartidas = s.Split(",")

        'iniciando os calculos
        servicos.IniciarProcessamentoCampeonato(vetpartidas)

        'ordenando a lista do campeonato
        servicos.OrdenarLista()

        'aplicando a posicao de cada time
        servicos.AplicarPosicao()

        'exbindo o resultado final
        servicos.FormatarExibicaoDados()

        'aguardando entrada
        Console.ReadKey()

    End Sub


End Module
