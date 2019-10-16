// <copyright file="IntervenantExterne.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ClassesMetier
{
    /// <summary>
    /// Classe intervenantExterne.
    /// </summary>
    public class IntervenantExterne : Intervenant
    {
        private string specialite;
        private string adresse;
        private string tel;

        /// <summary>
        /// Initializes a new instance of the <see cref="IntervenantExterne"/> class.
        /// </summary>
        /// <param name="nom">Nom.</param>
        /// <param name="prenom">Prenom.</param>
        /// <param name="specialite">Specialite.</param>
        /// <param name="adresse">Adresse.</param>
        /// <param name="tel">Tel.</param>
        public IntervenantExterne(string nom, string prenom, string specialite, string adresse, string tel)
            : base(nom, prenom)
        {
            this.specialite = specialite;
            this.adresse = adresse;
            this.tel = tel;
        }

        /// <summary>
        /// Gets Specialite.
        /// </summary>
        public string Specialite
        {
            get { return this.specialite; }
        }

        /// <summary>
        /// Gets Adresse.
        /// </summary>
        public string Adresse
        {
            get { return this.adresse; }
        }

        /// <summary>
        /// Gets Tel.
        /// </summary>
        public string Tel
        {
            get { return this.tel; }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return base.ToString() + " Spécialité : " + this.Specialite + "\n\t\t  " + this.Adresse + " - " + this.Tel;
        }
    }
}
