@Imports System.Web.Http
@Imports System.Web.Http.Description
@Imports WebApiDocTest.Areas.HelpPage.Models
@Imports WebApiDocTest.Areas.HelpPage.ModelDescriptions
@ModelType HelpPageApiModel

@Code
    Dim description As ApiDescription = Model.ApiDescription
End Code

<h1>@description.HttpMethod.Method @description.RelativePath</h1>
<div>
    <p>@description.Documentation</p>

    <br />
    <div class="greybox">

        <h2>Request Information</h2>

        <h3>URI Parameters</h3>
        @Html.DisplayFor(Function(m) m.UriParameters, "Parameters")


        <h3>Header Parameters</h3>
        @Html.DisplayFor(Function(m) m.HeaderParameters, "Parameters")

        <h3>Body Parameters</h3>

        <p>@Model.RequestDocumentation</p>

        @If Model.RequestModelDescription IsNot Nothing Then
            @Html.DisplayFor(Function(m) m.RequestModelDescription.ModelType, "ModelDescriptionLink", New With {.modelDescription = Model.RequestModelDescription})
            If Model.RequestBodyParameters IsNot Nothing Then
                @Html.DisplayFor(Function(m) m.RequestBodyParameters, "Parameters")
            End If
        Else
            @<p>None.</p>
        End If

        @If Model.SampleRequests.Count > 0 Then
            @<h3>Request Formats</h3>
            @Html.DisplayFor(Function(m) m.SampleRequests, "Samples")
        End If

    </div>

    <br />
    <div class="greybox">

        <h2>Response Information</h2>

        <p>@description.ResponseDescription.Documentation</p>

        @If Model.ResourceDescription IsNot Nothing Then
            @Html.DisplayFor(Function(m) m.ResourceDescription.ModelType, "ModelDescriptionLink", New With {.modelDescription = Model.ResourceDescription})
            If Model.ResourceProperties IsNot Nothing Then
                @Html.DisplayFor(Function(m) m.ResourceProperties, "Parameters")
            End If
        Else
            @<p>None.</p>
        End If


    </div>

    <br />
    <div Class="greybox">

        @If Model.SampleResponses.Count > 0 Then
            @<h3>Response Formats</h3>
            @Html.DisplayFor(Function(m) m.SampleResponses, "Samples")

        End If
    </div>

</div>
