using Final_SophieTravelManagement.Domain.Events;
using Final_SophieTravelManagement.Domain.Exceptions;
using Final_SophieTravelManagement.Domain.ValueObjects;
using Final_SophieTravelManagement.Shared.Abstractions.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Final_SophieTravelManagement.Domain.Entities
{
    public class TravelerCheckList : AggregateRoot<TravelerCheckListId>
    {
        public TravelerCheckListId Id { get; private set; }
        public TravelerCheckListName Name;
        public TravelerCheckListDestination Destination;
        private readonly LinkedList<TravelerCheckListItem> _items = new ();

        public TravelerCheckList()
        {

        }
        internal TravelerCheckList(TravelerCheckListId id, TravelerCheckListName name, TravelerCheckListDestination destination)
        {
            Id = id;
            Name = name;
            Destination = destination;
        }

        private TravelerCheckList(TravelerCheckListId id, TravelerCheckListName name, TravelerCheckListDestination destination,LinkedList<TravelerCheckListItem> items)
        :this(id,name,destination)
        {
            this._items = items;
        }


        public void AddItem(TravelerCheckListItem item)
        {
            var alreadyExist = _items.Any(x => x.Name == item.Name);
            if (alreadyExist)
                throw new TravelerItemAlreadyExistException(Name,item.Name);

            _items.AddLast(item);
            AddEvent(new TravelerItemAdded(this, item));
        }

        public void AddItems(IEnumerable<TravelerCheckListItem> items)
        {
            foreach (var item in items)
            {
                AddItem(item);
            }
        }
     

        public void TakeItem(string itemName)
        {
            var item = GetItem(itemName);
            var TravelerItem = item with { IsTaken = true };
            _items.Find(item).Value = TravelerItem;
            AddEvent(new TravelerItemTaken(this, item));
        }

        public void RemoveItem(string itemName)
        {
            var item = GetItem(itemName);
            _items.Remove(item);
            AddEvent(new TravelerItemRemoved(this, item));

        }

        private TravelerCheckListItem GetItem(string itemName)
        {
            var item = _items.SingleOrDefault(x => x.Name == itemName);
            if (item == null)
                throw new TravelerItemNotFoundException(itemName);

            return item;
        }

       
    }
}
