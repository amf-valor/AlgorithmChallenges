using System;

namespace CtCi.Solutions.ArraysAndStrings
{
    public class RotateMatrix
    {
        private readonly int[][] _squareMatrix;

        public RotateMatrix(int[][] squareMatrix)
        {
            if (squareMatrix.Length == 0 || squareMatrix == null)
            {
                throw new ArgumentException("matrix is not in NxN format");
            }

            _squareMatrix = squareMatrix;
        }

        public int[][] Rotate90Degree()
        {
            Layer layer = new Layer(_squareMatrix.Length - 1);
            
            while (layer.Row < _squareMatrix.Length / 2)
            {
                while (layer.Column < layer.Limit)
                {
                    int top = GetTop(layer);
                    SwapRightToTop(layer);
                    SwapBottomToRight(layer);
                    SwapLeftToBottom(layer);
                    PutTopOnBottom(layer, top);
                    layer.MoveToNextColumn();
                }

                layer.MoveNext();
            }

            return _squareMatrix;
        }
        private void SwapRightToTop(Layer layer)
        {
            _squareMatrix[layer.Row][layer.Column] = _squareMatrix[layer.Row + layer.Offset][layer.Limit];
        }
        private void SwapBottomToRight(Layer layer)
        {
            _squareMatrix[layer.Row + layer.Offset][layer.Limit] = _squareMatrix[layer.Limit][layer.Limit - layer.Offset];
        }
        private void SwapLeftToBottom(Layer layer)
        {
            _squareMatrix[layer.Limit][layer.Limit - layer.Offset] = _squareMatrix[layer.Limit - layer.Offset][layer.Row];
        }

        private void PutTopOnBottom(Layer layer, int top)
        {
            _squareMatrix[layer.Limit - layer.Offset][layer.Row] = top;
        }

        private int GetTop(Layer layer)
        {
            return _squareMatrix[layer.Row][layer.Column];
        }
        //TODO: layer could implement IEnumerable pattern
        private class Layer 
        {
            public int Row { get; private set; }
            public int Limit { get; private set; }
            public int Offset 
            {
                get { return Column - Row; }  
            }

            public int Column { get; private set; }

            public Layer(int limit)
            {
                Limit = limit;
            }

            public void MoveNext() 
            {
                Row++;
                Limit--;
                Column = Row;
            }

            public void MoveToNextColumn() 
            {
                Column++;
            }
        }
    }
}
