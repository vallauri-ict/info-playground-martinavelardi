using System.Windows.Forms;

namespace _27_interfaccia01
{
    class MyComponent : IDispAggiuntivo // lampadina, "implementa interfaccia"
    {
        private int _id;
        private bool _status;

        public int id { get => _id; set => _id = value; }
        public bool status => _status;

        public void connetti(string s)
        {
            _status = true;
            id++;
            MessageBox.Show("Connesso a: " + s);
        }

        public void disconnetti(string s)
        {
            _status = false;
            MessageBox.Show("Disconnesso da: " + s);
        }
        public void stato()
        {
            if (status)
                MessageBox.Show("Attualmente connesso con id: " + id);
            else
                MessageBox.Show("Non connesso");
        }
    }
}