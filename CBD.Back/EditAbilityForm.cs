using System.ComponentModel;

namespace CBD
{
    public class EditAbilityForm : INotifyPropertyChanged
    {
        public Cards.CardAbility Ability { get; set; }

        public Cards.ManaCost ManaCost
        {
            get { return Ability.Cost; }
            set
            {
                if (!value.Equals(Ability.Cost))
                {
                    Ability.Cost = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ManaCost)));
                }
            }
        }

        public string? Description
        {
            get { return Ability.Description; }
            set
            {
                if (value != null)
                {
                    if (!value.Equals(Ability.Description))
                    {
                        Ability.Description = value;
                        PropertyChanged?.Invoke(this, new(nameof(Description)));
                    }
                }
                else
                {
                    if (Ability.Description != null)
                    {
                        Ability.Description = value;
                        PropertyChanged?.Invoke(this, new(nameof(Description)));
                    }
                }
            }
        }

        public bool IsTap
        {
            get { return Ability.IsTap; }
            set
            {
                if (value != Ability.IsTap)
                {
                    Ability.IsTap = value;
                    PropertyChanged?.Invoke(this, new(nameof(IsTap)));
                }
            }
        }

        public List<int>? GameTags
        {
            get { return Ability.GameTags; }
            set
            {
                if ((value != null) && value.Any())
                {
                    Ability.GameTags = value;
                    PropertyChanged?.Invoke(this, new(nameof(GameTags)));
                }
                else
                {
                    if (Ability.GameTags != null)
                    {
                        Ability.GameTags = value;
                        PropertyChanged?.Invoke(this, new(nameof(GameTags)));
                    }
                }
            }
        }

        public EditAbilityForm() { Ability = new(); }
        public EditAbilityForm(Cards.CardAbility cardAbility)
        {
            Ability = cardAbility;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}