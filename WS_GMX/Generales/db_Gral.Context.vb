﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Linq

Partial Public Class GralEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=GralEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub


    Public Overridable Function spS_CatalogosOP(strCatalogo As String, condicion As String, strSel As String) As ObjectResult(Of spS_CatalogosOP_Result2)
        Dim strCatalogoParameter As ObjectParameter = If(strCatalogo IsNot Nothing, New ObjectParameter("strCatalogo", strCatalogo), New ObjectParameter("strCatalogo", GetType(String)))

        Dim condicionParameter As ObjectParameter = If(condicion IsNot Nothing, New ObjectParameter("Condicion", condicion), New ObjectParameter("Condicion", GetType(String)))

        Dim strSelParameter As ObjectParameter = If(strSel IsNot Nothing, New ObjectParameter("strSel", strSel), New ObjectParameter("strSel", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of spS_CatalogosOP_Result2)("spS_CatalogosOP", strCatalogoParameter, condicionParameter, strSelParameter)
    End Function

    Public Overridable Function spS_ListaPoliza(cod_suc As Nullable(Of Integer), cod_ramo As Nullable(Of Integer), nro_pol As Nullable(Of Decimal), str_pol As String, bln_Garantias As Nullable(Of Boolean), fechaIni As String, fechaFin As String, sn_Ajuste As Nullable(Of Integer)) As ObjectResult(Of spS_ListaPoliza_Result)
        Dim cod_sucParameter As ObjectParameter = If(cod_suc.HasValue, New ObjectParameter("cod_suc", cod_suc), New ObjectParameter("cod_suc", GetType(Integer)))

        Dim cod_ramoParameter As ObjectParameter = If(cod_ramo.HasValue, New ObjectParameter("cod_ramo", cod_ramo), New ObjectParameter("cod_ramo", GetType(Integer)))

        Dim nro_polParameter As ObjectParameter = If(nro_pol.HasValue, New ObjectParameter("nro_pol", nro_pol), New ObjectParameter("nro_pol", GetType(Decimal)))

        Dim str_polParameter As ObjectParameter = If(str_pol IsNot Nothing, New ObjectParameter("str_pol", str_pol), New ObjectParameter("str_pol", GetType(String)))

        Dim bln_GarantiasParameter As ObjectParameter = If(bln_Garantias.HasValue, New ObjectParameter("bln_Garantias", bln_Garantias), New ObjectParameter("bln_Garantias", GetType(Boolean)))

        Dim fechaIniParameter As ObjectParameter = If(fechaIni IsNot Nothing, New ObjectParameter("FechaIni", fechaIni), New ObjectParameter("FechaIni", GetType(String)))

        Dim fechaFinParameter As ObjectParameter = If(fechaFin IsNot Nothing, New ObjectParameter("FechaFin", fechaFin), New ObjectParameter("FechaFin", GetType(String)))

        Dim sn_AjusteParameter As ObjectParameter = If(sn_Ajuste.HasValue, New ObjectParameter("sn_Ajuste", sn_Ajuste), New ObjectParameter("sn_Ajuste", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of spS_ListaPoliza_Result)("spS_ListaPoliza", cod_sucParameter, cod_ramoParameter, nro_polParameter, str_polParameter, bln_GarantiasParameter, fechaIniParameter, fechaFinParameter, sn_AjusteParameter)
    End Function

    Public Overridable Function spS_cPAR_Parametros(cPAR_Id As Nullable(Of Integer)) As ObjectResult(Of String)
        Dim cPAR_IdParameter As ObjectParameter = If(cPAR_Id.HasValue, New ObjectParameter("cPAR_Id", cPAR_Id), New ObjectParameter("cPAR_Id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of String)("spS_cPAR_Parametros", cPAR_IdParameter)
    End Function

    Public Overridable Function spS_ListaEndoso(str_pol As String, fecEmision As String) As ObjectResult(Of spS_ListaEndoso_Result)
        Dim str_polParameter As ObjectParameter = If(str_pol IsNot Nothing, New ObjectParameter("str_pol", str_pol), New ObjectParameter("str_pol", GetType(String)))

        Dim fecEmisionParameter As ObjectParameter = If(fecEmision IsNot Nothing, New ObjectParameter("FecEmision", fecEmision), New ObjectParameter("FecEmision", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of spS_ListaEndoso_Result)("spS_ListaEndoso", str_polParameter, fecEmisionParameter)
    End Function

    Public Overridable Function spS_Pagador(id_pv As Nullable(Of Integer)) As ObjectResult(Of spS_Pagador_Result)
        Dim id_pvParameter As ObjectParameter = If(id_pv.HasValue, New ObjectParameter("id_pv", id_pv), New ObjectParameter("id_pv", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of spS_Pagador_Result)("spS_Pagador", id_pvParameter)
    End Function

    Public Overridable Function spS_PagadorCuotas(id_pv As Nullable(Of Integer), ind_pag As Nullable(Of Integer), cod_aseg As Nullable(Of Integer)) As ObjectResult(Of spS_PagadorCuotas_Result)
        Dim id_pvParameter As ObjectParameter = If(id_pv.HasValue, New ObjectParameter("id_pv", id_pv), New ObjectParameter("id_pv", GetType(Integer)))

        Dim ind_pagParameter As ObjectParameter = If(ind_pag.HasValue, New ObjectParameter("ind_pag", ind_pag), New ObjectParameter("ind_pag", GetType(Integer)))

        Dim cod_asegParameter As ObjectParameter = If(cod_aseg.HasValue, New ObjectParameter("cod_aseg", cod_aseg), New ObjectParameter("cod_aseg", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of spS_PagadorCuotas_Result)("spS_PagadorCuotas", id_pvParameter, ind_pagParameter, cod_asegParameter)
    End Function

    Public Overridable Function spS_DetallePagosCob(id_pv As Nullable(Of Integer), cod_aseg As Nullable(Of Integer), ind_pag As Nullable(Of Integer), nro_cuota As Nullable(Of Integer)) As ObjectResult(Of spS_DetallePagosCob_Result)
        Dim id_pvParameter As ObjectParameter = If(id_pv.HasValue, New ObjectParameter("id_pv", id_pv), New ObjectParameter("id_pv", GetType(Integer)))

        Dim cod_asegParameter As ObjectParameter = If(cod_aseg.HasValue, New ObjectParameter("cod_aseg", cod_aseg), New ObjectParameter("cod_aseg", GetType(Integer)))

        Dim ind_pagParameter As ObjectParameter = If(ind_pag.HasValue, New ObjectParameter("ind_pag", ind_pag), New ObjectParameter("ind_pag", GetType(Integer)))

        Dim nro_cuotaParameter As ObjectParameter = If(nro_cuota.HasValue, New ObjectParameter("nro_cuota", nro_cuota), New ObjectParameter("nro_cuota", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of spS_DetallePagosCob_Result)("spS_DetallePagosCob", id_pvParameter, cod_asegParameter, ind_pagParameter, nro_cuotaParameter)
    End Function

    Public Overridable Function spI_OfGread(strTabla As String, strKey As String, strDatos As String) As ObjectResult(Of spI_OfGread_Result)
        Dim strTablaParameter As ObjectParameter = If(strTabla IsNot Nothing, New ObjectParameter("strTabla", strTabla), New ObjectParameter("strTabla", GetType(String)))

        Dim strKeyParameter As ObjectParameter = If(strKey IsNot Nothing, New ObjectParameter("strKey", strKey), New ObjectParameter("strKey", GetType(String)))

        Dim strDatosParameter As ObjectParameter = If(strDatos IsNot Nothing, New ObjectParameter("strDatos", strDatos), New ObjectParameter("strDatos", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of spI_OfGread_Result)("spI_OfGread", strTablaParameter, strKeyParameter, strDatosParameter)
    End Function

    Public Overridable Function spS_EndososNoPagoOP(cod_usuario As String) As ObjectResult(Of spS_EndososNoPagoOP_Result)
        Dim cod_usuarioParameter As ObjectParameter = If(cod_usuario IsNot Nothing, New ObjectParameter("cod_usuario", cod_usuario), New ObjectParameter("cod_usuario", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of spS_EndososNoPagoOP_Result)("spS_EndososNoPagoOP", cod_usuarioParameter)
    End Function

    Public Overridable Function spS_Aclaracion(id_pv As Nullable(Of Integer)) As ObjectResult(Of spS_Aclaracion_Result)
        Dim id_pvParameter As ObjectParameter = If(id_pv.HasValue, New ObjectParameter("id_pv", id_pv), New ObjectParameter("id_pv", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of spS_Aclaracion_Result)("spS_Aclaracion", id_pvParameter)
    End Function

    Public Overridable Function spS_Usuario(cod_usuarioNT As String) As ObjectResult(Of spS_Usuario_Result)
        Dim cod_usuarioNTParameter As ObjectParameter = If(cod_usuarioNT IsNot Nothing, New ObjectParameter("cod_usuarioNT", cod_usuarioNT), New ObjectParameter("cod_usuarioNT", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of spS_Usuario_Result)("spS_Usuario", cod_usuarioNTParameter)
    End Function

    Public Overridable Function spS_MenuWeb(cod_usuario As String, cod_modulo As Nullable(Of Short)) As ObjectResult(Of spS_MenuWeb_Result)
        Dim cod_usuarioParameter As ObjectParameter = If(cod_usuario IsNot Nothing, New ObjectParameter("cod_usuario", cod_usuario), New ObjectParameter("cod_usuario", GetType(String)))

        Dim cod_moduloParameter As ObjectParameter = If(cod_modulo.HasValue, New ObjectParameter("cod_modulo", cod_modulo), New ObjectParameter("cod_modulo", GetType(Short)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of spS_MenuWeb_Result)("spS_MenuWeb", cod_usuarioParameter, cod_moduloParameter)
    End Function

    Public Overridable Function spI_Bitacora(cod_modulo As Nullable(Of Short), cod_submodulo_web As Nullable(Of Integer), cod_usuario As String, descripcion As String) As ObjectResult(Of spI_Bitacora_Result)
        Dim cod_moduloParameter As ObjectParameter = If(cod_modulo.HasValue, New ObjectParameter("cod_modulo", cod_modulo), New ObjectParameter("cod_modulo", GetType(Short)))

        Dim cod_submodulo_webParameter As ObjectParameter = If(cod_submodulo_web.HasValue, New ObjectParameter("cod_submodulo_web", cod_submodulo_web), New ObjectParameter("cod_submodulo_web", GetType(Integer)))

        Dim cod_usuarioParameter As ObjectParameter = If(cod_usuario IsNot Nothing, New ObjectParameter("cod_usuario", cod_usuario), New ObjectParameter("cod_usuario", GetType(String)))

        Dim descripcionParameter As ObjectParameter = If(descripcion IsNot Nothing, New ObjectParameter("Descripcion", descripcion), New ObjectParameter("Descripcion", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of spI_Bitacora_Result)("spI_Bitacora", cod_moduloParameter, cod_submodulo_webParameter, cod_usuarioParameter, descripcionParameter)
    End Function

    Public Overridable Function spI_ErrorWeb(cod_modulo As Nullable(Of Short), cod_submodulo_web As Nullable(Of Integer), cod_usuario As String, [error] As String) As ObjectResult(Of spI_ErrorWeb_Result)
        Dim cod_moduloParameter As ObjectParameter = If(cod_modulo.HasValue, New ObjectParameter("cod_modulo", cod_modulo), New ObjectParameter("cod_modulo", GetType(Short)))

        Dim cod_submodulo_webParameter As ObjectParameter = If(cod_submodulo_web.HasValue, New ObjectParameter("cod_submodulo_web", cod_submodulo_web), New ObjectParameter("cod_submodulo_web", GetType(Integer)))

        Dim cod_usuarioParameter As ObjectParameter = If(cod_usuario IsNot Nothing, New ObjectParameter("cod_usuario", cod_usuario), New ObjectParameter("cod_usuario", GetType(String)))

        Dim errorParameter As ObjectParameter = If([error] IsNot Nothing, New ObjectParameter("error", [error]), New ObjectParameter("error", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of spI_ErrorWeb_Result)("spI_ErrorWeb", cod_moduloParameter, cod_submodulo_webParameter, cod_usuarioParameter, errorParameter)
    End Function

End Class
