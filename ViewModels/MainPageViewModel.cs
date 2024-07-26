using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13E21925597.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string lado1;
        [ObservableProperty]
        private string lado2;
        [ObservableProperty]
        private string lado3;
        [ObservableProperty]
        private string area;

        [RelayCommand]
        private void CalcularArea()
        {
            if (double.TryParse(Lado1, out double l1) && double.TryParse(Lado2, out double l2) && double.TryParse(Lado3, out double l3))
            {
                double suma = (l1 + l2 + l3) / 2;
                double calculo = suma * (suma - l1) * (suma - l2) * (suma - l3);
                Area = "El área del triángulo es : " + Math.Sqrt(calculo).ToString();
            }
            else
            {
                Area = "Ingrese datos numéricos";
            }
        }
    }
}
