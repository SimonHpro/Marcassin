﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace DAL
{
    public static class Extension
    {
        public static List<Langue_BO> ToListLangueBO(this List<Langue> list)
        {
            if (list == null)
            {
                return null;
            }
            List<Langue_BO> listLanguesBO = new List<Langue_BO>();
            foreach (Langue lan in list)
            {
                var bo = new Langue_BO
                {
                    id_Langue = lan.id_Langue,
                    Langue_intitule = lan.Langue_intitule,
                    Par_Defaut = lan.Par_Defaut
                };

                listLanguesBO.Add(bo);
            }
            return listLanguesBO;
        }

        public static List<Service_BO> ToListServiceBO(this List<Service> list)
        {
            if (list == null)
            {
                return null;
            }
            List<Service_BO> listServicesBO = new List<Service_BO>();
            foreach (Service ser in list)
            {
                var bo = new Service_BO
                {
                    id_Service = ser.id_Service,
                    Nom = ser.Nom,
                    id_chef = ser.id_chef,
                    GUID = ser.GUID
                };

                listServicesBO.Add(bo);
            }
            return listServicesBO;
        }

        public static List<Badge_BO> ToListBadgeBO(this List<Badge> list)
        {
            if (list == null)
            {
                return null;
            }
            List<Badge_BO> listBadgeBO = new List<Badge_BO>();
            foreach (Badge bad in list)
            {
                var bo = new Badge_BO
                {
                    id_Badge = bad.id_Badge,
                    Image = bad.images,
                    Intitule = bad.nom
                };


                listBadgeBO.Add(bo);
            }
            return listBadgeBO;
        }

        public static List<Utilisateur_BO> ToListUtilisateurBO(this List<Utilisateur> list)
        {
            if (list == null)
            {
                return null;
            }

            List<Utilisateur_BO> listUtilisateurBO = new List<Utilisateur_BO>();
            foreach (Utilisateur uti in list)
            {
                var bo = new Utilisateur_BO
                {
                    id_Utilisateur = uti.id_Utilisateur,
                    Nom = uti.Nom,
                    Prenom = uti.Prenom,
                    Mail = uti.Mail,
                    Numero_Telephone = uti.Numero_Telephone,
                    Adresse = uti.Adresse,
                    Ville = uti.Ville,
                    Region = uti.Region,
                    Pays = uti.Pays,
                    Sexe = uti.Sexe,
                    Est_intervenant = uti.Est_intervenant,
                    GUID = uti.GUID,
                    Linkedin = uti.Linkedin
                };


                listUtilisateurBO.Add(bo);
            }
            return listUtilisateurBO;
        }
        public static List<Personnel_BO> ToListPersonnelBO(this List<Personnel> list)
        {
            if (list == null)
            {
                return null;
            }
            List<Personnel_BO> listPersonnelBO = new List<Personnel_BO>();
            foreach (Personnel pers in list)
            {
                var bo = new Personnel_BO
                {
                    id_Utilisateur = pers.id_Utilisateur,
                    Date_deb_contrat = pers.Date_deb_contrat,
                    Date_fin_contrat = pers.Date_fin_contrat,
                    Est_admin = pers.Est_admin
                };

                listPersonnelBO.Add(bo);
            }
            return listPersonnelBO;
        }

        public static List<LangueBadge_BO> ToListLangueBadgeBO (this List<Langue_Badge> list)

        

        {
            if (list == null)
            {
                return null;
            }

            List<LangueBadge_BO> listLangueBadgeBO = new List<LangueBadge_BO>();
            foreach (Langue_Badge lanbad in list)
            {
                var bo = new LangueBadge_BO
                {
                    id_Badge=lanbad.id_Badge,
                    id_Langue=lanbad.id_Langue,
                    Traduction_Badge = lanbad.Traduction
                };
            }
            return listLangueBadgeBO;
        }
        public static List<LangueCompetence_BO> ToListLangueCompetenceBO (this List<Langue_Competence> list)
        {
            if (list == null)
            {
                return null;
            }
            List<LangueCompetence_BO> listLangueCompetenceBO = new List<LangueCompetence_BO>();
            foreach (Langue_Competence lancom in list)
            {
                var bo = new LangueCompetence_BO
                {
                    id_Competence=lancom.id_Competence,
                    id_Langue=lancom.id_Langue,
                    Traduction=lancom.Traduction
                };
            }
            return listLangueCompetenceBO;
        }
        public static List<CategorieLangue_BO> ToListCategorieLangueBO (this List<Categorie_Langue> list)
        {
            if (list == null)
            {
                return null;
            }
            List<CategorieLangue_BO> listCategorieLangueBO = new List<CategorieLangue_BO>();
            foreach (Categorie_Langue catlan in list)
            {
                var bo = new CategorieLangue_BO
                {
                    id_Categorie=catlan.Id_Categorie,
                    id_Langue=catlan.id_Langue,
                    Traduction=catlan.Traduction
                };
            }
            return listCategorieLangueBO;
        }
            public static List<Participant_BO> ToListParticipantBO(this List<Participant> list)
            {
            List<Participant_BO> listParticipantBO = new List<Participant_BO>();
            foreach (Participant part in list)
            {
                var bo = new Participant_BO()
                {
                    id_Utilisateur = part.id_Utilisateur,
                    id_Cours = part.id_Cours,
                    est_orga = part.est_orga
                };
                listParticipantBO.Add(bo);
            }

            return listParticipantBO;
        }
        public static List<UtilisateurCompetence_BO> ToListUtilisateurCompetence(this List<Utilisateur_Competence> list)
        {
            if(list == null)
            {
                return null;
            }
            List<UtilisateurCompetence_BO> listUtilisateurCompetenceBO = new List<UtilisateurCompetence_BO>();
            foreach(Utilisateur_Competence Uticomp in list)
            {
                var bo = new UtilisateurCompetence_BO()
                {
                    id_Utilisateur = Uticomp.id_Utilisateur,
                    id_Competence = Uticomp.id_Compétence,
                    note = Uticomp.note
                };
            }
            return null;

        }
    }

}
