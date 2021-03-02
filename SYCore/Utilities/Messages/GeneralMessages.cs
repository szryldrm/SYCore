using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYCore.Utilities.Messages
{
    public static class GeneralMessages
    {
        public static string ERROR_MESSAGE(LangCode langCode)
        {
            switch (langCode)
            {
                case LangCode.EN:
                    return "SORRY, AN ERROR HAS OCCURRED! DETAILS: ";
                case LangCode.TR:
                    return "UZGUNUM, BIR HATA OLUSTU! DETAYLAR: ";
                case LangCode.DE:
                    return "ENTSCHULDIGUNG, EIN FEHLER IST AUFGETRETEN! EINZELHEITEN: ";
                case LangCode.ES:
                    return "LO SENTIMOS, HA OCURRIDO UN ERROR! DETALLES: ";
                case LangCode.RU:
                    return "ИЗВИНИТЕ, ПРОИЗОШЛА ОШИБКА! ДЕТАЛИ: ";
                default:
                    return "SORRY, AN ERROR HAS OCCURRED! DETAILS: ";
            }
        }

        public static string NOT_FOUND(string name, LangCode langCode)
        {
            switch (langCode)
            {
                case LangCode.EN:
                    return name + " NOT FOUND!";
                case LangCode.TR:
                    return name + " BULUNAMADI!";
                case LangCode.DE:
                    return name + " NICHT GEFUNDEN!";
                case LangCode.ES:
                    return name + " NO ENCONTRADO!";
                case LangCode.RU:
                    return name + " НЕ НАЙДЕН!";
                default:
                    return name + " NOT FOUND!";
            }            
        }

        public static string ADDED(string name, LangCode langCode)
        {
            switch (langCode)
            {
                case LangCode.EN:
                    return name + " ADDED SUCCESSFULLY";
                case LangCode.TR:
                    return name + " BASARIYLA EKLENDI";
                case LangCode.DE:
                    return name + " ERFOLGREICH HINZUGEFUGT";
                case LangCode.ES:
                    return name + " AGREGADO EXITOSAMENTE";
                case LangCode.RU:
                    return name + " УСПЕШНО ДОБАВЛЕН";
                default:
                    return name + " ADDED SUCCESSFULLY";
            }            
        }
        public static string NOT_ADDED(string name, LangCode langCode)
        {
            switch (langCode)
            {
                case LangCode.EN:
                    return name + " NOT ADDED!";
                case LangCode.TR:
                    return name + " EKLENEMEDI!";
                case LangCode.DE:
                    return name + " NICHT HINZUGEFUGT!";
                case LangCode.ES:
                    return name + " NO AÑADIDO!";
                case LangCode.RU:
                    return name + " НЕ ДОБАВЛЕН!";
                default:
                    return name + " NOT ADDED!";
            }
        }
        public static string UPDATED(string name, LangCode langCode)
        {
            switch (langCode)
            {
                case LangCode.EN:
                    return name + " UPDATED SUCCESSFULLY";
                case LangCode.TR:
                    return name + " BASARIYLA GUNCELLENDI";
                case LangCode.DE:
                    return name + " ERFOLGREICH GEUPDATED";
                case LangCode.ES:
                    return name + " ACTUALIZADO CON ÉXITO";
                case LangCode.RU:
                    return name + " УСПЕШНО ОБНОВЛЕНО";
                default:
                    return name + " UPDATED SUCCESSFULLY";
            }            
        }

        public static string NOT_UPDATED(string name, LangCode langCode)
        {
            switch (langCode)
            {
                case LangCode.EN:
                    return name + " NOT UPDATED!";
                case LangCode.TR:
                    return name + " GUNCELLENEMEDI!";
                case LangCode.DE:
                    return name + " NICHT AKTUALISIERT!";
                case LangCode.ES:
                    return name + " NO ACTUALIZADA/NO ACTUALIZADO!";
                case LangCode.RU:
                    return name + " НЕ ОБНОВЛЯЮТСЯ!";
                default:
                    return name + " NOT UPDATED!";
            }            
        }

        public static string DELETED(string name, LangCode langCode)
        {
            switch (langCode)
            {
                case LangCode.EN:
                    return name + " DELETED SUCCESSFULLY";
                case LangCode.TR:
                    return name + " BASARIYLA SILINDI";
                case LangCode.DE:
                    return name + " ERFOLGREICH GELÖSCHT";
                case LangCode.ES:
                    return name + " BORRADO EXITOSAMENTE";
                case LangCode.RU:
                    return name + " УДАЛЕНО УСПЕШНО";
                default:
                    return name + " DELETED SUCCESSFULLY";
            }
        }

        public static string NOT_DELETED(string name, LangCode langCode)
        {
            switch (langCode)
            {
                case LangCode.EN:
                    return name + " NOT DELETED!";
                case LangCode.TR:
                    return name + " SILINEMEDI!";
                case LangCode.DE:
                    return name + " NICHT GELÖSCHT!";
                case LangCode.ES:
                    return name + " NO ELIMINADA/NO ELIMINADO!";
                case LangCode.RU:
                    return name + " НЕ УДАЛЕНО!";
                default:
                    return name + " NOT DELETED!";
            }
        }
    }
}
