const input = document.getElementById("password");
  const submitButton= document.getElementById("login-button");
  input.addEventListener("Keyup",(e)=>
  {
    const value=e.currentTarget.value;
    if(value==="")
    {
      submitButton.disabled=true;

    }
    else{
    submitButton.disabled=false;
    }
  });