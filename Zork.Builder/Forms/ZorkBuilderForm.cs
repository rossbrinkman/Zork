using System;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using Zork.Builder.Forms;

namespace Zork.Builder
{
    public partial class ZorkBuilderForm : Form
    {
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
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string jsonString = File.ReadAllText(openFileDialog.FileName);
                ViewModel.World = JsonConvert.DeserializeObject<World>(jsonString);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private WorldViewModel _viewModel;

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room(addRoomForm.RoomName);
                    ViewModel.Rooms.Add(room);
                }
            }
        }
    }
}
