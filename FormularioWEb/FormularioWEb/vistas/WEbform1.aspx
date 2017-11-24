<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WEbform1.aspx.cs" Inherits="FormularioWEb.WebForm1" %>

<!DOCTYPE html>
<!DOCTYPE html>
<html lang="es">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Formulario Login</title>
     <%-- <script src="javascript/Validacion.js"></script>--%>
 
    <!-- CSS de Bootstrap -->
    <link rel="stylesheet" href="../css/bootstrap.min.css">
    <link rel="stylesheet" href="../font-awesome/css/font-awesome.min.css"> <!--Iconos--> 
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Raleway:100,300,400,500" >
    <link rel="stylesheet" href="../css/custom.css">
     
      
    
  </head>

  <body>      
      <form id="form1" runat="server">
    <div class="my-content" >
        <div class="container" > 
            <div class="row">
                <div class="col-sm-12" >
                  <h1><strong>WebForm</strong> Registration Form</h1>
                  <div class="mydescription">
                    <p>Formulario web Diplomado ASP.NET </p>
                  </div>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6 col-sm-offset-3 myform-cont">
                    <div class="myform-top">
                        <div class="myform-top-left">
                            <h3> <strong>Welcome</strong> to my site.</h3>
                            <p>Please enter your personal information</p>
                        </div>
                        <div class="myform-top-right">
                            <i class="fa fa-users" aria-hidden="true"></i>
                        </div>
                    </div>
                    <div class="myform-bottom"> 
                            <div class="form-group ml-3" >
                                   <div style="margin-right:60px">
                                <asp:TextBox ID="nametxt" runat="server" Width="512" Height ="50 " class="form-control " placeholder="name..."></asp:TextBox>
                               </div>

                              <%--  <input type="text"  name="form-firtsname"  placeholder="Name..."  class="form-control" id="name">--%>


                            </div>
                            <div class="form-group ">

                                  <div style="margin-right:60px">
                                     
                                <asp:TextBox ID="lastnametxt" runat="server" Width="512" Height ="50 " class="form-control " placeholder="Lastname..."></asp:TextBox>
                                        
                               </div>
                              
                              <%--  <input type="text" name="form-lastname" placeholder="Lastname..." class="form-control" id="Lastname">--%>
                            </div>
                            <div class="form-group">
                              <%--  <input type="text" name="form-cedula" placeholder="ced..." class="form-control" id="cedula">--%>
                                <div style="margin-right:60px">
                                   
                                <asp:TextBox ID="idtxt" runat="server" Width="512" Height ="50 " class="form-control " placeholder="id...."></asp:TextBox>
                                        
                               </div>
                            </div>



                            <div class="form-group">
                               <%-- <input type="date" name="form-birthdate"  class="form-control" id="birthday-">--%>
                            </div>
                            <div class="form-group">

                                  <div style="margin-right:60px">
                                <asp:TextBox ID="TextBox3" runat="server" Width="512" Height ="50 " class="form-control"></asp:TextBox>
                               </div>
                               <%-- <input type="text" name="form-email" placeholder="Email..." class="form-control" id="email">--%>
                            </div>

                            <div class="form-group">

                                  <div style="margin-right:60px">
                                <asp:TextBox ID="TextBox4" runat="server" Width="512" Height ="50 " class="form-control"></asp:TextBox>
                               </div>
                               <%-- <input type="text" name="form-tel" placeholder="phone number..." class="form-control" id="phone"--%>
                            </div>
                            <div class="col">

                              
                                    <select name="pais" id="pais" class="form-control  ">
                                        <option value="SEL">Choose Contry</option>
                                        <option value="DR">Dominican Republic</option>
                                        <option value="UK">United Kingdom</option>
                                        <option value="US">United States</option>
                                        <option value="SW">Swizeland </option>
                                        
                                       

                                    </select>
                                    <div style="margin-top:15px"></div>


                                    <select name="profesion" id="profesion" class="form-control mt-3">
                                        <option value="none">Choose Career</option>
                                        <option value="Sf">Software Developer</option>
                                        <option value="NT">Networks</option>
                                        <option value="DB">Data Base</option>
                                        <option value="SW">Swizeland </option>
                                    </select>
                                    
                                    </div>
                            <h4>Sexo </h4>
                            <hr />
                            <div class="form-check  form-check-inline ">

                                <label class="Radio ">
                                    <input type="Radio" name="sexo" id="hombre" value="hombre" > Hombre
                                </label>
                            </div>
                            <div class="form-check  form-check-inline ">

                                <label class="Radio">
                                    <input type="Radio" name="sexo" id="mujer" value="mujer"> Mujer
                                </label>
                            </div>
                             <hr />
                        </div>

                     <%--   <script type  ="text/javascript">
                            function Mifucion() {
                                alert("Probando esta mierda");
                            
                            }
                        </script>--%>

                        <script type="text/javascript">
                            function Validar() {

                                // Expresion regular para  validar que el correo sea valido donde /\w+ = texto +@ el arroba
                                // \w mas texto \. mas punto + [a-z] una letra comprendida desde la a hasta la z
                                var expresion = /\w+@\w+\.+[a-z]/;

                                var name = document.getElementById("name").value;
                                var Lastname = document.getElementById("Lastname").value;
                                var cedula = document.getElementById("cedula").value;
                                var email = document.getElementById("email").value;
                                var phone = document.getElementById("phone").value;


                                var arr = [name, Lastname, cedula, email];


                                for (var i = 0; i < arr.length; i++)


                                    if (arr[i] == "") {
                                        alert("All fields are required");
                                        return false;
                                    }
                                    else if (isNaN(phone)) {
                                        alert(" invalid number ");
                                        return false;
                                    }

                                    else if (!expresion.test(email)) {
                                        alert("Invalid mail");
                                        return false;
                                    }

                            }
                        </script>
                      <button type="submit" value="" onclick="Validar()" class="mybtn" >
                        
                          Check in</button>
                           

                </div>
              </div>
            </div>
            <div class="row">
                <div class="col-sm-12 mysocial-login">
                    <h4>enter by</h4>
                    <div class="mysocial-login-buttons" >
                      <a class="mybtn-social" href="#">
                      <i class="fa fa-facebook"></i> Facebook
                      </a>
                      <a class="mybtn-social" href="#">
                      <i class="fa fa-instagram"></i> Instagram
                      </a>
                      <a class="mybtn-social" href="#">
                      <i class="fa fa-snapchat"></i> Snapachat
                      </a>
                    </div>
                </div>
            </div>
        </div>
      </div>

    <!-- Enlazamos el js de Bootstrap, y otros plugins que usemos siempre al final antes de cerrar el body -->
     
    
      <script src="js/jquery-3.2.1.min.js"></script>
      <script src="js/popper.min.js"></script>
      <script src="js/boostrap.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
      </form>
  </body>
</html>