Imports Newtonsoft.Json
Imports Models

Public Class SampleController
    Inherits BaseController
    Public Function SampleAPI(data1 As String, data2 As String) As SampleModel
        Dim endPoints = New Uri(String.Format(APICore.APIEndpoints.BaseUrl + APICore.APIEndpoints.SampleEndpoints, data1, data2))

        Dim jsonres = GetApiDataByUriJson(endPoints)

        Dim ret = JsonConvert.DeserializeObject(Of List(Of SampleModel))(jsonres)

        Return ret
    End Function
End Class
