﻿using Common;
using Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Markup;

namespace StripSegments
{
    /// <summary>Класс Полосы.</summary>
    [ContentProperty(nameof(Segments))]
    [DefaultProperty(nameof(Segments))]
    public class Strip : OnPropertyChangedClass, ICloneable<Strip>, IDto<StripDto>
    {
        #region Поля, хранящие значения одноимённых свойств
        private string _name;
        private StripDto _dto;
        private Segment _range;
        #endregion

        /// <summary>Имя Полосы.</summary>
        public string Name { get => _name; set => SetProperty(ref _name, value); }

        /// <summary>Сегменты Полосы.</summary>
        public ObservableCollection<Segment> Segments { get; }
            = new ObservableCollection<Segment>();

        /// <summary>Диапазон полосы.</summary>
        public Segment Range { get => _range; set => SetProperty(ref _range, value); }

        public StripDto Copy() => throw new NotImplementedException();

        public void CopyFrom(StripDto dto)
        {
            Name = dto.Name;
            Range.CopyFrom(dto.Range);

            // Изменение значений существующих элементов
            int i;
            for (i = 0; i < Segments.Count && i < dto.Segments.Count; i++)
                Segments[i].SetDto(dto.Segments[i]);

            // Удаление лишних элементов
            if (i < Segments.Count)
                for (; i < Segments.Count; i++)
                    Segments.RemoveAt(i);

            // Добавление нехватающих элементов
            else if (i < dto.Segments.Count)
                for (; i < dto.Segments.Count; i++)
                    Segments.Add(Segment.Create(dto.Segments[i]));

        }

        public void CopyTo(StripDto obj) => throw new NotImplementedException();

        #region Реализация интерфейса IDto<StripSegmentDto>
        public StripDto Dto { get => _dto; private set => SetProperty(ref _dto, value); }
        public void SetDto(StripDto newDto) => CopyFrom(Dto = newDto);
        #endregion

        #region Реализация интерфейса ICloneable<StripSegment>
        public Strip Clone() => (Strip)((ICloneable)this).Clone();
        object ICloneable.Clone() => MemberwiseClone();
        #endregion
    }
}
