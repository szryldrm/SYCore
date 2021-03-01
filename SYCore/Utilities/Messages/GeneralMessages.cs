using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYCore.Utilities.Messages
{
    public static class GeneralMessages
    {
        public static string ERROR_MESSAGE(string langCode = null)
        {
            if (langCode.Equals("TR", StringComparison.OrdinalIgnoreCase))
            {
                return "UZGUNUM, BIR HATA OLUSTU! DETAYLAR: ";
            }
            else if (langCode.Equals("DE", StringComparison.OrdinalIgnoreCase))
            {
                return "ENTSCHULDIGUNG, EIN FEHLER IST AUFGETRETEN! EINZELHEITEN: ";
            }
            else if (langCode.Equals("ES", StringComparison.OrdinalIgnoreCase))
            {
                return "LO SENTIMOS, HA OCURRIDO UN ERROR! DETALLES: ";
            }
            else if (langCode.Equals("RU", StringComparison.OrdinalIgnoreCase))
            {
                return "ИЗВИНИТЕ, ПРОИЗОШЛА ОШИБКА! ДЕТАЛИ: ";
            }

            return "SORRY, AN ERROR HAS OCCURRED! DETAILS: ";
        }

        public static string NOT_FOUND(string name, string langCode = null)
        {
            if (langCode.Equals("TR", StringComparison.OrdinalIgnoreCase))
            {
                return name + " BULUNAMADI!";
            }
            else if (langCode.Equals("DE", StringComparison.OrdinalIgnoreCase))
            {
                return name + " NICHT GEFUNDEN!";
            }
            else if (langCode.Equals("ES", StringComparison.OrdinalIgnoreCase))
            {
                return name + " NO ENCONTRADO!";
            }
            else if (langCode.Equals("RU", StringComparison.OrdinalIgnoreCase))
            {
                return name + " НЕ НАЙДЕН!";
            }

            return name + " NOT FOUND!";
        }

        public static string ADDED(string name, string langCode = null)
        {
            if (langCode.Equals("TR", StringComparison.OrdinalIgnoreCase))
            {
                return name + " BASARIYLA EKLENDI!";
            }
            else if (langCode.Equals("DE", StringComparison.OrdinalIgnoreCase))
            {
                return name + " ERFOLGREICH HINZUGEFUGT!";
            }
            else if (langCode.Equals("ES", StringComparison.OrdinalIgnoreCase))
            {
                return name + " AGREGADO EXITOSAMENTE!";
            }
            else if (langCode.Equals("RU", StringComparison.OrdinalIgnoreCase))
            {
                return name + " УСПЕШНО ДОБАВЛЕН!";
            }

            return name + " ADDED SUCCESSFULLY";
        }
        public static string NOT_ADDED(string name, string langCode = null)
        {
            if (langCode.Equals("TR", StringComparison.OrdinalIgnoreCase))
            {
                return name + " EKLENEMEDI!";
            }
            else if (langCode.Equals("DE", StringComparison.OrdinalIgnoreCase))
            {
                return name + " NICHT HINZUGEFUGT!";
            }
            else if (langCode.Equals("ES", StringComparison.OrdinalIgnoreCase))
            {
                return name + " NO AÑADIDO!";
            }
            else if (langCode.Equals("RU", StringComparison.OrdinalIgnoreCase))
            {
                return name + " НЕ ДОБАВЛЕН!";
            }

            return name + " NOT ADDED!";
        }

        public static string DELETED(string name, string langCode = null)
        {
            if (langCode.Equals("TR", StringComparison.OrdinalIgnoreCase))
            {
                return name + " BASARIYLA SILINDI!";
            }
            else if (langCode.Equals("DE", StringComparison.OrdinalIgnoreCase))
            {
                return name + " ERFOLGREICH GELÖSCHT!";
            }
            else if (langCode.Equals("ES", StringComparison.OrdinalIgnoreCase))
            {
                return name + " BORRADO EXITOSAMENTE!";
            }
            else if (langCode.Equals("RU", StringComparison.OrdinalIgnoreCase))
            {
                return name + " УДАЛЕНО УСПЕШНО!";
            }
            return name + " DELETED SUCCESSFULLY";
        }
        public static string NOT_DELETED(string name, string langCode = null)
        {
            if (langCode.Equals("TR", StringComparison.OrdinalIgnoreCase))
            {
                return name + " SILINEMEDI!";
            }
            else if (langCode.Equals("DE", StringComparison.OrdinalIgnoreCase))
            {
                return name + " NICHT GELÖSCHT!";
            }
            else if (langCode.Equals("ES", StringComparison.OrdinalIgnoreCase))
            {
                return name + " NO ELIMINADA/NO ELIMINADO!";
            }
            else if (langCode.Equals("RU", StringComparison.OrdinalIgnoreCase))
            {
                return name + " НЕ УДАЛЕНО!";
            }
            return name + " NOT DELETED!";
        }

        public static string UPDATED(string name, string langCode = null)
        {
            if (langCode.Equals("TR", StringComparison.OrdinalIgnoreCase))
            {
                return name + " BASARIYLA GUNCELLENDI!";
            }
            else if (langCode.Equals("DE", StringComparison.OrdinalIgnoreCase))
            {
                return name + " ERFOLGREICH GEUPDATED!";
            }
            else if (langCode.Equals("ES", StringComparison.OrdinalIgnoreCase))
            {
                return name + " ACTUALIZADO CON ÉXITO!";
            }
            else if (langCode.Equals("RU", StringComparison.OrdinalIgnoreCase))
            {
                return name + " УСПЕШНО ОБНОВЛЕНО!";
            }
            return name + " UPDATED SUCCESSFULLY";
        }
        public static string NOT_UPDATED(string name, string langCode = null)
        {
            if (langCode.Equals("TR", StringComparison.OrdinalIgnoreCase))
            {
                return name + " GUNCELLENEMEDI!";
            }
            else if (langCode.Equals("DE", StringComparison.OrdinalIgnoreCase))
            {
                return name + " NICHT AKTUALISIERT!";
            }
            else if (langCode.Equals("ES", StringComparison.OrdinalIgnoreCase))
            {
                return name + " NO ACTUALIZADA/NO ACTUALIZADO!";
            }
            else if (langCode.Equals("RU", StringComparison.OrdinalIgnoreCase))
            {
                return name + " НЕ ОБНОВЛЯЮТСЯ!";
            }

            return name + " NOT UPDATED!";
        }
    }
}
