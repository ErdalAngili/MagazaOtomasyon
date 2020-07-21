using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazaOtomasyon.Business.CrossCuttingConcerns.Validation.FluentValidation
{
    public class ValidatorTool
    {

        public static void FluentValidate(IValidator validator, object entitiy)
        {
            var result = validator.Validate(entitiy);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
