namespace CarRentalSystem.Main
{
    public interface IFormFactory
    {
        T CreateForm<T>() where T : Form;
    }
}
