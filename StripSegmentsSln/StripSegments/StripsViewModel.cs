﻿using Models;
using System;
using System.Collections.Generic;
using System.Windows;

namespace StripSegments
{

    public class StripsViewModel : StripsViewModelProperties
    {
        private readonly StripsModel Model;

        public StripsViewModel(StripsModel model) => Model = model;

        public override void Load()
        {
            Model.Load();
            Step = Model.GetStep();
            Size = Model.GetSize();
            GetStrips(Model.GetRange());
        }

        protected async override void GetStrips(SegmentDto segmentDto)
        {

            IReadOnlyList<StripDto> strips = await Model.GetStripsAsync(segmentDto).ConfigureAwait(true);

            if (Application.Current.Dispatcher.CheckAccess())
                UpdateStrips(strips);
            else
                _ = Application.Current.Dispatcher.BeginInvoke((Action<IReadOnlyList<StripDto>>)UpdateStrips, strips);

        }

        private void UpdateStrips(IReadOnlyList<StripDto> strips)
        {
            Range = Model.GetRange();


            // Изменение значений существующих элементов
            int i;
            for (i = 0; i < Strips.Count && i < strips.Count; i++)
                Strips[i].SetDto(strips[i]);

            // Удаление лишних элементов
            if (i < Strips.Count)
                for (int ii = Strips.Count - 1; i <= ii; ii--)
                    Strips.RemoveAt(ii);

            // Добавление нехватающих элементов
            else if (i < strips.Count)
                for (; i < strips.Count; i++)
                    Strips.Add(Strip.Create(strips[i]));
        }
    }

}
