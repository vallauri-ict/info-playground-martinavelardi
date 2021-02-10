namespace _27_interfaccia01
{
    interface IDispAggiuntivo
    {
        int id { get; set; }
        bool status { get; }
        void connetti(string s);
        void disconnetti(string s);
    }
}