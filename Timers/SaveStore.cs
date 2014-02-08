using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Timers
{
    public class SaveStore
    {
        public static void SaveControls(TimerContainerStore Container)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileInfo fi = new FileInfo("TimerDatastore.dat");
            if (fi.Exists == true)
            {
                fi.Delete();
            }
            FileStream fs = new FileStream("TimerDatastore.dat", FileMode.OpenOrCreate);
            bf.Serialize(fs, Container);
            fs.Close();
        }

        public static TimerContainerStore LoadControls()
        {
            FileStream fs = null;
            FileInfo fi = new FileInfo("TimerDatastore.dat");
            TimerContainerStore Container;

            if (fi.Exists == true)
            {
                try
                {
                    fs = new FileStream("TimerDatastore.dat", FileMode.Open);

                    BinaryFormatter bf = new BinaryFormatter();

                    Container = (TimerContainerStore)bf.Deserialize(fs);

                    /*
                    for (int i = 0; i < Container.Timers.Count(); i++)
                    {
                        actionClockControl acc = new actionClockControl(Container.getTimer(i));
                        uxFlowPanel.Controls.Add(acc);
                    }
                    */
                }
                catch (FileNotFoundException)
                {
                    //MessageBox.Show("Couldn't find datastore, creating it now.");
                    Container = new TimerContainerStore();
                    return Container;
                }
                catch
                {
                    //MessageBox.Show("Couldn't parse file");
                    Container = new TimerContainerStore();
                    return Container;
                }
                finally
                {
                    if (fs != null)
                        fs.Close();
                }
            }
            else
            {
                Container = new TimerContainerStore();
            }
            return Container;
        }
    }
}
