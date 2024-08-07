function validateForm() {
  var username = document.getElementById('username').value;
  var password = document.getElementById('password').value;

   if (username.trim() === '') {
      displayErrorMessage("Username cannot be empty.");
      return false;
   }

   if (password.trim() === '') {
      displayErrorMessage("Password cannot be empty.");
      return false;
   }
   clearErrorMessage();
   return true;
}
function displayErrorMessage(message) {
  var errorMessageElement = document.getElementById('errorMessage');
  errorMessageElement.textContent = message;
}

function clearErrorMessage() {
   var errorMessageElement = document.getElementById('errorMessage');
   errorMessageElement.textContent = '';
}

function togglePasswordVisibility() {
  var passwordInput = document.getElementById('password');
  var eyeIcon = document.getElementById('eye-icon');

   if (passwordInput.type === 'password') {
      passwordInput.type = 'text';
      eyeIcon.src = '@Url.Content("~/images/close eyes.jpg")';
   } else {
      passwordInput.type = 'password';
      eyeIcon.src = '@Url.Content("~/images/open eyes.jpg")';
   }
}