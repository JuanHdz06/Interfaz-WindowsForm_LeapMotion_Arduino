using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Leap;

namespace ELaip.Presentacion
{
    public partial class FrmAjustes : Form, ILeapEventDelegate
    {
        SerialPort coon;
        private Controller controller;
        private LeapEventListener listener;
        public FrmAjustes()
        {
            InitializeComponent();
            this.controller = new Controller();
            this.listener = new LeapEventListener(this);
            controller.AddListener(listener);
            Init();
        }

        private void Init()
        {
            coon = new SerialPort();
            coon.PortName = "COM5";
            coon.BaudRate = 9600;


            try
            {
                coon.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        

        


        delegate void LeapEventDelegate(string EventName);
        public void LeapEventNotification(string EventName)
        {
            if (!this.InvokeRequired)
            {
                switch (EventName)
                {
                    case "onInit":

                        //MessageBox.Show("Conexion Establecida");
                        break;
                    case "onConnect":
                        this.connectHandler();
                        break;
                    case "onFrame":
                        if (!this.Disposing)
                            this.newFrameHandler(this.controller.Frame());
                        break;
                }
            }
            else
            {
                BeginInvoke(new LeapEventDelegate(LeapEventNotification), new object[] { EventName });
            }
        }

        void connectHandler()
        {
            this.controller.EnableGesture(Gesture.GestureType.TYPE_CIRCLE);
            this.controller.Config.SetFloat("Gesture.Circle.MinRadius", 40.0f);
            this.controller.EnableGesture(Gesture.GestureType.TYPE_SWIPE);
        }

        void newFrameHandler(Frame frame)
        {
            
            double Ar,Ar2,Ar3,rot,mune;
            for (int h = 0; h < frame.Hands.Count; h++)
            {
                Hand leapHand = frame.Hands[h];

                Vector handXBasis = leapHand.PalmNormal.Cross(leapHand.Direction).Normalized;
                Vector handYBasis = -leapHand.PalmNormal;
                Vector handZBasis = -leapHand.Direction;
                Vector handOrigin = leapHand.PalmPosition;
                Matrix handTransform = new Matrix(handXBasis, handYBasis, handZBasis, handOrigin);
                handTransform = handTransform.RigidInverse();
                    //this.textBox2.Text = handOrigin.x.ToString();
                //this.textBox4.Text = handOrigin.y.ToString();

                for (int f = 0; f < leapHand.Fingers.Count; f++)
                {
                    Finger leapFinger = leapHand.Fingers[f];
                    Vector transformedPosition = handTransform.TransformPoint(leapFinger.TipPosition);
                    Vector transformedDirection = handTransform.TransformDirection(leapFinger.Direction);

                    Ar = (handOrigin.x * -.18) + 135; // codo
                    Ar2 = (handOrigin.y - 40) * .31;    // base
                    Ar3 = (handOrigin.z * .3) + 90;
                    rot = (-handXBasis.x * 183.67) + 180;//rotacion de la muñeca
                    mune = (transformedDirection.x * 225) + 90; //abre cierra pinza
                    if (Ar < 180 && Ar > 90)
                    {
                        int myInt = (int)Math.Ceiling(Ar);
                        this.textBox5.Text = myInt.ToString();
                    }

                    if (Ar2 < 180 && Ar2 > 0)
                    {
                        int myInt2 = (int)Math.Ceiling(Ar2);
                        this.textBox6.Text = myInt2.ToString();
                    }

                    if (Ar3 <= 180 && Ar3 >= 0)
                    {
                        int myInt = (int)Math.Ceiling(Ar3);
                        this.textBoxz.Text = myInt.ToString();
                    }

                    if (rot <= 180 && rot >= 0)
                    {
                        int myInt4 = (int)Math.Ceiling(rot);
                        this.textBoxm.Text = myInt4.ToString();
                    }

                    if (mune > 145)
                    {
                        this.textBoxp.Text = 90.ToString();
                    }

                    if (mune < 144)
                    {
                        this.textBoxp.Text = 0.ToString();
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (coon.IsOpen)
            {
                coon.WriteLine(textBox5.Text + "2");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            if (coon.IsOpen)
            {
                coon.WriteLine(textBox6.Text + "5");
            }
        }

        private void textBoxz_TextChanged(object sender, EventArgs e)
        {
            if (coon.IsOpen)
            {
                coon.WriteLine(textBoxz.Text + "6");
            }
        }

        private void textBoxm_TextChanged(object sender, EventArgs e)
        {
            if (coon.IsOpen)
            {
                coon.WriteLine(textBoxm.Text + "3");
            }
        }

        private void textBoxp_TextChanged(object sender, EventArgs e)
        {
            if (coon.IsOpen)
            {
                coon.WriteLine(textBoxp.Text + "7");
            }
        }
    }
}
