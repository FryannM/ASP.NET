

function Validar()
{


    
   
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