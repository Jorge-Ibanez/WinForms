using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsContacts
{
    class BussinessLogicLayer
    {
        private DataAccessLayer _dataAccessLayer;

        public BussinessLogicLayer()
        {
            _dataAccessLayer = new DataAccessLayer();
        }

        public Contacto SaveContacto(Contacto contacto)
        {   
            if ( contacto.Id == 0 )                         // Examen - P4
            _dataAccessLayer.InsertContacto(contacto);
            else                                            // Examen - P4
            _dataAccessLayer.UpdateContacto(contacto);      // Examen - P4


            return contacto;
        }

        public List<Contacto> GetContactos(string searchString = null)
        {
            return _dataAccessLayer.GetContactos(searchString);
        }

        public void DeleteContacto(Contacto contacto)
        {
            _dataAccessLayer.DeleteContacto(contacto.Id);
        }
    }
}
