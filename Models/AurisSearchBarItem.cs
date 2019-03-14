using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AurisAPITest.Models
{
    public class AurisSearchBarItem : IAurisSearchBarItem
    {
        public int ID { get; set; }
        public string Category { get; set; }

        private int _order;
        public int Order
        {
            get { return _order; }
            set
            {
                if (_order == value) return;
                _order = value;
            }
        }


        private bool _isSelected = false;
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                if (_isSelected == value) return;
                _isSelected = value;
            }
        }

        private bool _isVisible = false;
        public bool IsVisible
        {
            get { return _isVisible; }
            set
            {
                if (_isVisible == value) return;
                _isVisible = value;
            }
        }

        private bool _isFirstItem = false;
        public bool IsFirstItem
        {
            get { return _isFirstItem; }
            set
            {
                if (_isFirstItem == value) return;
                _isFirstItem = value;
            }
        }


        private string _displayName = string.Empty;
        public string Value
        {
            get
            {
                if (string.IsNullOrEmpty(_displayName) && string.IsNullOrEmpty(Category) == false) return Category;
                return _displayName;
            }
            set
            {
                if (_displayName == value) return;

                _displayName = value;
            }
        }

        private bool _isActive = true;
        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                if (_isActive == value) return;
                _isActive = value;
            }
        }
    }
}