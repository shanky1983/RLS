using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using FluentValidation.Attributes;

namespace LIMSAPI.Models
{
   // [Validator(typeof(GetValidateUsers))]
    public class GetValidateUsers
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FCMInstanceId { get; set; }
        public string DeviceId { get; set; }
        public string AppVersionNo { get; set; }
    }
    public class GetValidateUsersValidater : AbstractValidator<GetValidateUsers>
    {
        public GetValidateUsersValidater()
        {
            RuleFor(o => o.Email).NotEmpty().WithMessage("email_id field missing");
            RuleFor(o => o.Password).NotEmpty().WithMessage("password field missing");
            RuleFor(o => o.FCMInstanceId).NotEmpty().WithMessage("FCMInstanceId field missing");
            RuleFor(o => o.DeviceId).NotEmpty().WithMessage("DeviceId field missing");
        }
    }
}