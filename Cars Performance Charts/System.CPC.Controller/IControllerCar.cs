/*
 * Interface responsible for declaration of Car table control  methods
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CPC.Model.Bean;

/*
 * CPC / Controller / ICar
 * @author MRX
 * Version : 1.0.0
 */

namespace System.CPC.Controller
{
    public interface IControllerCar
    {

        bool Validate(Car car);

    }
}
