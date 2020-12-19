namespace OOP._02___Pilares_OOP
{
    public class AutomacaoCafe
    {
        public void ServirCafe()
        {
            var espresso = new Cafeteria();
            espresso.Ligar();
            espresso.PrepararCafe();
            espresso.Desligar();
        }
    }
}