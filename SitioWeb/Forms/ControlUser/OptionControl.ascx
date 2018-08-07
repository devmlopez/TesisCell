<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OptionControl.ascx.cs" Inherits="SitioWeb.Forms.ControlUser.OptionControl" %>

<style>
    .barraBotones{
        min-height:30px!important;
        max-height:100px!important;
        height:30px!important;
        padding-top:0px!important;
        padding-bottom:0px!important;

    }
    .rojolink{
        color:red!important;
    }
     .azullink{
          color:blue!important;
    }
      .verdelink{
           color:green!important;
    }
       .violetalink{
            color:blueviolet !important;
    }
        .brownlink{
             color:brown!important;
    }
         .crimsonlink{
              color:crimson!important;
    }

          .rojolink,
          .azullink,
          .verdelink,
          .violetalink,
          .brownlink,
          .crimsonlink{
             font-weight:bold;
             font-size:12px!important;
    }
          .iconSize{
              font-size:35px!important;
          }
          .BotonEfecto:hover{
            
          }

</style>
  <section class="content barraBotones">
        <div class="row">
<div class="btn-group" role="group" aria-label="Basic example">
 <%-- <a href="ot.aspx"  class="btn  btn-default BotonEfecto"><i class="fa fa-check-square-o iconSize violetalink" ></i> Ordenes de Trabajo</a>
  <a href="informetecnico.aspx"   class="btn  btn-default BotonEfecto "><i class="fa fa-clipboard iconSize crimsonlink "></i> Informe Técnicos</a>
  <a href="FV.aspx"   class="btn  btn-default BotonEfecto"><i class="fa fa-usd iconSize verdelink BotonEfecto"></i> Facturas de Ventas</a>
  <a href="Programacionmantenimiento.aspx"   class="btn  btn-default BotonEfecto"><i class="fa fa-calendar iconSize brownlink"></i> Prog/Mantenimiento</a>    --%>
  <a href="cliente.aspx"   class="btn  btn-default BotonEfecto"><i class="fa fa-users iconSize rojolink"></i> Clientes</a>    
  <a href="proveedor.aspx"   class="btn  btn-default BotonEfecto"><i class="fa fa-users iconSize azullink"></i> Proveedores</a>
</div>    
     </div>
         </section>



