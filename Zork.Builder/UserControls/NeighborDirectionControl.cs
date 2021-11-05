using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Zork.Common;

namespace Zork.Builder.UserControls
{
    public partial class NeighborDirectionControl : UserControl
    {
        public static readonly Room NoNeighbor = new Room() { Name = "None" };

        public Room Room
        {
            get => mRoom;
            set
            {
                if (mRoom != value)
                {
                    mRoom = value;
                    if (Room != null)
                    {
                        var rooms = new List<Room>((IEnumerable<Room>)mRoom.Neighbors);
                        rooms.Insert(0, NoNeighbor);
                        neighborComboBox.SelectedIndexChanged -= neighborComboBox_SelectedIndexChanged;
                        neighborComboBox.DataSource = rooms;

                        if (mRoom.Neighbors.TryGetValue(Direction, out Room neighbor))
                        {
                            Neighbor = neighbor;
                        }
                        else
                        {
                            Neighbor = NoNeighbor;
                        }

                        neighborComboBox.SelectedIndexChanged += neighborComboBox_SelectedIndexChanged;
                    }
                    else
                    {
                        neighborComboBox.DataSource = null;
                    }
                }
            }
        }

        public Directions Direction
        {
            get => mDirection;
            set
            {
                mDirection = value;
                directionTextBox.Text = value.ToString();
            }
        }

        public Room Neighbor
        {
            get => (Room)neighborComboBox.SelectedItem;
            set => neighborComboBox.SelectedItem = value;
        }

        public NeighborDirectionControl()
        {
            InitializeComponent();
        }

        public NeighborDirectionControl(Directions direction, Room room)
        {
            Direction = direction;
            Neighbor = room ?? throw new ArgumentNullException(nameof(room));
        }

        private void neighborComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mRoom != null)
            {
                Room selectedRoom = (Room)neighborComboBox.SelectedItem;
                if (selectedRoom == NoNeighbor)
                {
                    mRoom.Neighbors.Remove(Direction);
                }
                else
                {
                    mRoom.Neighbors[Direction] = selectedRoom;
                }
            }
        }

        private Room mRoom;
        private Directions mDirection;
    }
}
