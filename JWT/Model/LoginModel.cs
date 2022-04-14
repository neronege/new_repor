﻿using System.ComponentModel.DataAnnotations;

namespace JWT.Model
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Kullanıcı adı boş geçilmez")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Parolanızı giriniz")]
        public string Password { get; set; }
    }
}
