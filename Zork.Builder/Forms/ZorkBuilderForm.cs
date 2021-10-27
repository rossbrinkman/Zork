using System;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Zork.Builder.Forms;

namespace Zork.Builder
{
    public partial class ZorkBuilderForm : Form
    {
        private bool WorldIsLoaded
        {
            get
            {
                return _viewModel.WorldIsLoaded;
            }
            set
            {
                _viewModel.WorldIsLoaded = value;

                foreach (var control in _worldDependentControls)
                {
                    control.Enabled = _viewModel.WorldIsLoaded;
                }
                foreach (var menuItem in _worldDependentMenuItems)
                {
                    menuItem.Enabled = _viewModel.WorldIsLoaded;
                }

            }
        }
        private WorldViewModel ViewModel 
        {
            get => _viewModel;
            set
            {
                if(_viewModel != value)
                {
                    _viewModel = value;
                    worldViewModelBindingSource.DataSource = _viewModel;
                }
            }
        }
        
        public ZorkBuilderForm()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();

            _worldDependentControls = new Control[]
            {
                //addRoomButton,
                //deleteRoomButton
            };

            _worldDependentMenuItems = new MenuItem[]
            {

            };

            WorldIsLoaded = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonString = File.ReadAllText(openFileDialog.FileName);
                    ViewModel.World = JsonConvert.DeserializeObject<World>(jsonString);
                    ViewModel.WorldIsLoaded = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private WorldViewModel _viewModel;
        private Control[] _worldDependentControls;
        private MenuItem[] _worldDependentMenuItems;

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room existingRoom = ViewModel.Rooms.FirstOrDefault(room => room.Name.Equals(addRoomForm.RoomName, StringComparison.OrdinalIgnoreCase));
                    if (existingRoom != null)
                    {
                        MessageBox.Show("Room already exists.", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Room room = new Room(addRoomForm.RoomName);
                        ViewModel.Rooms.Add(room);
                    }
                }
            }
        }
    }
}
