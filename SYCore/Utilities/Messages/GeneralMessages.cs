using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYCore.Utilities.Messages
{
    public static class GeneralMessages
    {
        public enum Language
        {
            EN, TR, DE, ES, RU
        }

        public static string ERROR_MESSAGE(Language? langCode)
        {
            if (langCode.Equals(Language.EN))
            {
                return "SORRY, AN ERROR HAS OCCURRED! DETAILS: ";
            }
            else if (langCode.Equals(Language.TR))
            {
                return "UZGUNUM, BIR HATA OLUSTU! DETAYLAR: ";
            }
            else if (langCode.Equals(Language.DE))
            {
                return "ENTSCHULDIGUNG, EIN FEHLER IST AUFGETRETEN! EINZELHEITEN: ";
            }
            else if (langCode.Equals(Language.ES))
            {
                return "LO SENTIMOS, HA OCURRIDO UN ERROR! DETALLES: ";
            }
            else if (langCode.Equals(Language.RU))
            {
                return "ИЗВИНИТЕ, ПРОИЗОШЛА ОШИБКА! ДЕТАЛИ: ";
            }

            return "SORRY, AN ERROR HAS OCCURRED! DETAILS: ";
        }

        public static string NOT_FOUND(string name, Language? langCode)
        {
            if (langCode.Equals(Language.EN))
            {
                return name + " NOT FOUND!";
            }
            else if (langCode.Equals(Language.TR))
            {
                return name + " BULUNAMADI!";
            }
            else if (langCode.Equals(Language.DE))
            {
                return name + " NICHT GEFUNDEN!";
            }
            else if (langCode.Equals(Language.ES))
            {
                return name + " NO ENCONTRADO!";
            }
            else if (langCode.Equals(Language.RU))
            {
                return name + " НЕ НАЙДЕН!";
            }

            return name + " NOT FOUND!";
        }

        public static string ADDED(string name, Language? langCode)
        {
            if (langCode.Equals(Language.EN))
            {
                return name + " ADDED SUCCESSFULLY";
            }
            else if (langCode.Equals(Language.TR))
            {
                return name + " BASARIYLA EKLENDI";
            }
            else if (langCode.Equals(Language.DE))
            {
                return name + " ERFOLGREICH HINZUGEFUGT";
            }
            else if (langCode.Equals(Language.ES))
            {
                return name + " AGREGADO EXITOSAMENTE";
            }
            else if (langCode.Equals(Language.RU))
            {
                return name + " УСПЕШНО ДОБАВЛЕН";
            }

            return name + " ADDED SUCCESSFULLY";
        }
        public static string NOT_ADDED(string name, Language? langCode)
        {
            if (langCode.Equals(Language.EN))
            {
                return name + " NOT ADDED!";
            }
            else if (langCode.Equals(Language.TR))
            {
                return name + " EKLENEMEDI!";
            }
            else if (langCode.Equals(Language.DE))
            {
                return name + " NICHT HINZUGEFUGT!";
            }
            else if (langCode.Equals(Language.ES))
            {
                return name + " NO AÑADIDO!";
            }
            else if (langCode.Equals(Language.RU))
            {
                return name + " НЕ ДОБАВЛЕН!";
            }

            return name + " NOT ADDED!";
        }
        public static string UPDATED(string name, Language? langCode)
        {
            if (langCode.Equals(Language.EN))
            {
                return name + " UPDATED SUCCESSFULLY";
            }
            else if (langCode.Equals(Language.TR))
            {
                return name + " BASARIYLA GUNCELLENDI";
            }
            else if (langCode.Equals(Language.DE))
            {
                return name + " ERFOLGREICH GEUPDATED";
            }
            else if (langCode.Equals(Language.ES))
            {
                return name + " ACTUALIZADO CON ÉXITO";
            }
            else if (langCode.Equals(Language.RU))
            {
                return name + " УСПЕШНО ОБНОВЛЕНО";
            }
            return name + " UPDATED SUCCESSFULLY";
        }

        public static string NOT_UPDATED(string name, Language? langCode)
        {
            if (langCode.Equals(Language.EN))
            {
                return name + " NOT UPDATED!";
            }
            else if (langCode.Equals(Language.TR))
            {
                return name + " GUNCELLENEMEDI!";
            }
            else if (langCode.Equals(Language.DE))
            {
                return name + " NICHT AKTUALISIERT!";
            }
            else if (langCode.Equals(Language.ES))
            {
                return name + " NO ACTUALIZADA/NO ACTUALIZADO!";
            }
            else if (langCode.Equals(Language.RU))
            {
                return name + " НЕ ОБНОВЛЯЮТСЯ!";
            }

            return name + " NOT UPDATED!";
        }

        public static string DELETED(string name, Language? langCode)
        {
            if (langCode.Equals(Language.EN))
            {
                return name + " DELETED SUCCESSFULLY";
            }
            else if (langCode.Equals(Language.TR))
            {
                return name + " BASARIYLA SILINDI";
            }
            else if (langCode.Equals(Language.DE))
            {
                return name + " ERFOLGREICH GELÖSCHT";
            }
            else if (langCode.Equals(Language.ES))
            {
                return name + " BORRADO EXITOSAMENTE";
            }
            else if (langCode.Equals(Language.RU))
            {
                return name + " УДАЛЕНО УСПЕШНО";
            }
            return name + " DELETED SUCCESSFULLY";
        }

        public static string NOT_DELETED(string name, Language? langCode)
        {
            if (langCode.Equals(Language.EN))
            {
                return name + " NOT DELETED!";
            }
            else if (langCode.Equals(Language.TR))
            {
                return name + " SILINEMEDI!";
            }
            else if (langCode.Equals(Language.DE))
            {
                return name + " NICHT GELÖSCHT!";
            }
            else if (langCode.Equals(Language.ES))
            {
                return name + " NO ELIMINADA/NO ELIMINADO!";
            }
            else if (langCode.Equals(Language.RU))
            {
                return name + " НЕ УДАЛЕНО!";
            }
            return name + " NOT DELETED!";
        }
    }
}
