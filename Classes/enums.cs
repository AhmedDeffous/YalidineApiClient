using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace YalidineApiClient.Classes
{
    public enum payment_status
    {
        [Description("not-ready")] notReady
            , [Description("ready")] ready
            , [Description("receivable")] receivable
            , [Description("payed")] payed


    }
    public enum last_status
    {
        [Description("Pas encore expédié")] Pas_encore_expedie
     , [Description("A vérifier")] A_verifier
     , [Description("En préparation")] En_preparation
     , [Description("Pas encore ramassé")] Pas_encore_ramasse
     , [Description("Prêt à expédier")] Pret_a_expedier
     , [Description("Ramassé")] Ramasse
     , [Description("Bloqué")] Bloque
     , [Description("Débloqué")] Debloque
     , [Description("Transfert")] Transfert
     , [Description("Expédié")] Expedie
     , [Description("Centre")] Centre
     , [Description("En localisation")] En_localisation
     , [Description("Vers Wilaya")] Vers_Wilaya
     , [Description("Reçu à Wilaya")] Reçu_a_Wilaya
     , [Description("En attente du client")] En_attente_du_client
     , [Description("Prêt pour livreur")] Pret_pour_livreur
     , [Description("Sorti en livraison")] Sorti_en_livraison
     , [Description("En attente")] En_attente
     , [Description("En alerte")] En_alerte
     , [Description("Tentative échouée")] Tentative_echouee
     , [Description("Livré")] Livre
     , [Description("Echèc livraison")] Echèc_livraison
     , [Description("Retour vers centre")] Retour_vers_centre
     , [Description("Retourné au centre")] Retourne_au_centre
     , [Description("Retour transfert")] Retour_transfert
     , [Description("Retour groupé")] Retour_groupe
     , [Description("Retour à retirer")] Retour_a_retirer
     , [Description("Retour vers vendeur")] Retour_vers_vendeur
     , [Description("Retourné au vendeur")] Retourne_au_vendeur
     , [Description("Echange échoué")] Echange_echoue
    }
    public static class EnumExtensions
    {
        public static string ToFriendlyString(this last_status status)
        {
            var field = status.GetType().GetField(status.ToString());
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attribute != null ? attribute.Description : status.ToString();
        }
        public static string ToFriendlyString(this payment_status status)
        {
            var field = status.GetType().GetField(status.ToString());
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attribute != null ? attribute.Description : status.ToString();
        }
    }
 }
