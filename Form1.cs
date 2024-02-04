using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_House
{
    public partial class Form1 : Form
    {
        Location currentLocation;
        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(livingRoom);
        }

        public void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Living Room", "An antique carpet", "an oak door with a brass knob");
            diningRoom = new Room("Dining Room", "a crystal chandeller");
            kitchen = new RoomWithDoor("Kitchen","stainless steel appliances", "a screen door");
            frontYard = new OutsideWithDoor("Front Yard", false,"an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            garden = new Outside("Garden", false);

            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom };
            kitchen.Exits = new Location[] { diningRoom };
            frontYard.Exits = new Location[] { backYard, garden };
            backYard.Exits = new Location[] { frontYard, garden };
            garden.Exits = new Location[] { backYard, frontYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;

        }
        private void MoveToANewLocation(Location newLocation)
        {
            currentLocation = newLocation;
            descriptionTextBox.Text = newLocation.Description;
            exitsComboBox.Items.Clear();

            foreach(var exit in newLocation.Exits)
            {
                exitsComboBox.Items.Add(exit.Name);
            }
            exitsComboBox.SelectedIndex = 0;
            goThroughTheDoorButton.Visible = currentLocation is IHasExteriorDoor;
        }

        private void goHereButton_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exitsComboBox.SelectedIndex]);
        }

        private void goThroughTheDoorButton_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor currentLocationWithDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(currentLocationWithDoor.DoorLocation);
        }
    }
}
