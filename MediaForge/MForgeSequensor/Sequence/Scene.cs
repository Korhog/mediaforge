﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MForge.Sequensor.Sequence
{
    public class Scene
    {
        private SequenceController sequensor;
        public SequenceController Sequensor { get { return sequensor; } }

        private TimeSpan duration;
        /// <summary> Длительность сцены </summary>
        public TimeSpan Duration { get; }
        
        private int frameDuration = 100;
        /// <summary> Длительность сцены в кадрах </summary>
        public int FrameDuration { get { return frameDuration; } }

        public Scene()
        {
            sequensor = new SequenceController();

            sequensor.Sequences.Add(new SequenceSingleBase(new SequenceElementBase()));
            sequensor.Sequences.Add(new SequenceSingleBase(new SequenceElementBase()));
            sequensor.Sequences.Add(new SequenceSingleBase(new SequenceElementBase()));
        }

        public ObservableCollection<ISequence> Sequences { get { return sequensor.Sequences; } }
    }
}
