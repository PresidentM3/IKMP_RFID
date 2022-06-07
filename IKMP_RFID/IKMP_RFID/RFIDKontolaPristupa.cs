using System.IO.Ports;

namespace IKMP_RFID
{
    public partial class RFIDKontolaPristupa : Form
    {
        SerialPort _serialPort;

        public RFIDKontolaPristupa()
        {
            InitializeComponent();
            InitSerailPort();
        }

        private void InitSerailPort()
        {
            _serialPort = new SerialPort("COM15", 9600, Parity.None, 8, StopBits.One);
            _serialPort.Open();
            _serialPort.DataReceived += SerialPort_DataReceived;
        }


        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string msg = _serialPort.ReadLine();
            print2list(msg);

        }


        private void print2list(string poruka)
        {
            if (listBox1.InvokeRequired)
            {
                listBox1.Invoke((MethodInvoker)(() =>
                {
                    //listBox1.Items.Add("InvokeRequired");
                    listBox1.Items.Add(poruka);
                }));
            }
            else
            {
                listBox1.Items.Add(poruka);
            }


        }

    }
}