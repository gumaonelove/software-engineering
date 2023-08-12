using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Figures;

namespace Lab4
{
    public partial class Form1 : Form
    {
        private Stack<Operator> operators = new Stack<Operator>();
        private Stack<Operand> operands = new Stack<Operand>();
        // объект для обеспечения связи между списком фигур и списком элемента listBox
        private BindingSource bs = new BindingSource();

        int sq_count = 0;
        public Form1()
        {
            InitializeComponent();
            // Иницилизация и настройка объектов, необходимых для прорисовки, хранения и отображения фигур.
            Init.bitmap = new Bitmap(pictureBoxWindow.ClientSize.Width, pictureBoxWindow.ClientSize.Height);
            Init.pen = new Pen(Color.Black, 3);
            Init.pictureBox = pictureBoxWindow;
            Init.figuresListBox = listBoxFigures;

            ShapeContainer figure_list = new ShapeContainer();
            bs.DataSource = ShapeContainer.figureList;
            Init.figuresListBox.DataSource = bs;
            Init.figuresListBox.DisplayMember = "Info";
        }
        private void textBoxInputString_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                operators.Clear();
                operands.Clear();
                
                // Обработка введенной строки. Заполение стеков операторов и операндов
                string sourceExpression = textBoxInputString.Text.Replace(" ", "");
                for (int i = 0; i < sourceExpression.Length; i++)
                {
                    char c = sourceExpression[i];
                    if (IsNotOperation(c))
                    {
                        // формирование операнда - строки
                        if (!Char.IsDigit(c))
                        {
                            operands.Push(new Operand(c));
                            while (i < sourceExpression.Length - 1 && IsNotOperation(sourceExpression[i + 1]))
                            {
                                string temp_str = operands.Pop().value.ToString() + sourceExpression[i + 1].ToString();
                                operands.Push(new Operand(temp_str));
                                i++;
                            }
                        }
                        // формирование операнда - числа
                        else if (Char.IsDigit(c))
                        {
                            operands.Push(new Operand(c.ToString()));
                            while (i < sourceExpression.Length - 1 && Char.IsDigit(sourceExpression[i + 1])
                                && IsNotOperation(sourceExpression[i + 1]))
                            {
                                // умножение предыдущего числа на 10 и запись текущего как более младший разряд
                                int temp_num = Convert.ToInt32(operands.Pop().value.ToString()) * 10 +
                                    (int)Char.GetNumericValue(sourceExpression[i + 1]);
                                operands.Push(new Operand(temp_num));
                                i++;
                            }
                        }
                    }

                    else if ((c == 'S') || (c == 'M') || (c == 'D') || (c == 'I'))
                    {
                        if (operators.Count == 0)
                        {
                            operators.Push(OperatorContainer.FindOperator(c));
                        }
                    }
                    else if (sourceExpression[i] == '(')
                    {
                        operators.Push(OperatorContainer.FindOperator(sourceExpression[i]));
                    }
                    // При равенстве текущего символа закрывающей фигурной скобке происходит извлечение
                    // элементов из стека операторов до тех пор, пока не будет достигнута
                    // открывающая фигурная скобка.
                    else if (c == ')')
                    {
                        do
                        {
                            if (operators.Peek().symbolOperator == '(')
                            {
                                operators.Pop();
                                break;
                            }
                            if (operators.Count == 0)
                            {
                                break;
                            }
                        }
                        while (operators.Peek().symbolOperator != '(');
                    }
                }
                // Вызов метода обработки функциональный выражений
                if (operators.Count > 0)
                {
                    if (IsNotOperation(operators.Peek().symbolOperator))
                    {
                        MessageBox.Show("Введенной операции не существует.");
                        commandsList.Items.Add("Введенной операции не существует.");
                    }
                    else
                    {
                        if (ParameterCheck())
                        {
                            SelectingPerformingOperation(operators.Pop());
                        }
                        else
                        {
                            MessageBox.Show("Команда введена некорректно.");
                            commandsList.Items.Add("Команда введена некорректно.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Вы не ввели операцию.");
                    commandsList.Items.Add("Вы не ввели операцию.");
                }
            }
        }
        /// <summary>
        /// Метод, проверяющий наличие фигуры с указаным именем в списке фигур
        /// </summary>
        /// <param name="name">Имя, которое необходимо проверить</param>
        /// <returns>Возвращает true, если фигуры с указанным именем нет</returns>
        private bool CheckName(string name)
        {
            foreach (Square asq in ShapeContainer.figureList)
            {
                if (asq.user_name == name)
                {
                    return false;
                }  
            }
            return true;
        }
        /// <summary>
        /// Метод обработки функциональных выражений. Выполняет действия в зависимости от переданного оператора.
        /// </summary>
        /// <param name="op">Объект оператора, задающий команду</param>
        private void SelectingPerformingOperation(Operator op)
        {
            // Создание квадрата
            if (op.symbolOperator == 'S')
            {
                if (operands.Count == 4)
                {
                    sq_count += 1;
                    int a = Convert.ToInt32(operands.Pop().value.ToString());
                    int y = Convert.ToInt32(operands.Pop().value.ToString());
                    int x = Convert.ToInt32(operands.Pop().value.ToString());
                    string name = operands.Pop().value.ToString();
                    if (CheckName(name))
                    {
                        if (Init.Coords_check(x, y, a, a))
                        {
                            Square figure = new Square(sq_count, x, y, a, name);
                            op = new Operator(figure.Draw, 'S');
                            ShapeContainer.AddFigure(figure);
                            bs.ResetBindings(false);
                            commandsList.Items.Add($"Квадрат {figure.user_name} отрисован");
                            op.operatorMethod();
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                            commandsList.Items.Add("Фигура вышла за границы.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Фигура с таким именем уже сужествует.");
                        commandsList.Items.Add("Фигура с таким именем уже сужествует.");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Опертор S принимает 4 аргумента.");
                    commandsList.Items.Add("Неверное число аргументов для оператора S.");
                }
            }
            // Перемещение квадрата
            else if (op.symbolOperator == 'M')
            {
                if (operands.Count == 3)
                {
                    Square figure = null;
                    int y = Convert.ToInt32(operands.Pop().value.ToString());
                    int x = Convert.ToInt32(operands.Pop().value.ToString());
                    string name = operands.Pop().value.ToString();
                    foreach (Square f in ShapeContainer.figureList)
                    {
                        if(f.user_name == name)
                        {
                            figure = (Square)f;
                        }
                    }
                    if (figure != null)
                    {
                        if (Init.Coords_check(figure.x + x, figure.y + y, figure.w, figure.h))
                        {
                            figure.MoveTo(x, y);
                            bs.ResetBindings(false);
                            commandsList.Items.Add($"Фигура {figure.user_name} успешно перемещена");
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                            commandsList.Items.Add("Фигура вышла за границы.");
                        }
                    }
                    else
                    {
                        commandsList.Items.Add($"Фигуры {name} не существует");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор M принимает 3 аргумента.");
                    commandsList.Items.Add("Неверное число аргументов для оператора M.");
                }
            }
            // Изменение стороны квадрата
            else if (op.symbolOperator == 'I')
            {
                if (operands.Count == 2)
                {
                    Square figure = null;
                    int ca = Convert.ToInt32(operands.Pop().value.ToString());
                    string name = operands.Pop().value.ToString();
                    foreach (Square f in ShapeContainer.figureList)
                    {
                        if (f.user_name == name)
                        {
                            figure = (Square)f;
                        }
                    }
                    if (figure != null)
                    {
                        if (Init.Coords_check(figure.x, figure.y, ca, ca))
                        {
                            figure.w = ca;
                            figure.h = ca;
                            figure.DeleteF(figure, false);
                            figure.Draw();
                            commandsList.Items.Add($"Фигура {figure.user_name} изменена.");
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                            commandsList.Items.Add("Фигура вышла за границы.");
                        }
                    }
                    else
                    {
                        commandsList.Items.Add($"Фигуры {name} не существует");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор I принимает 2 аргумента.");
                    commandsList.Items.Add("Неверное число аргументов для оператора I.");
                }
            }
            // Удаление квадрата
            else if (op.symbolOperator == 'D')
            {
                if (operands.Count == 1)
                {
                    Square figure = null;
                    string name = operands.Pop().value.ToString();
                    foreach (Square f in ShapeContainer.figureList)
                    {
                        if (f.user_name == name)
                        {
                            figure = (Square)f;
                        }
                    }
                    if (figure != null)
                    {
                        figure.DeleteF(figure, true);
                        bs.ResetBindings(false);
                        commandsList.Items.Add($"Фигура {figure.user_name} удалена.");
                    }
                    else
                    {
                        commandsList.Items.Add($"Фигуры {name} не существует.");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор D принимает 1 аргумент.");
                    commandsList.Items.Add("Неверное число аргументов для оператора D.");
                }
            }
        }
        /// <summary>
        /// Метод, проверяющий, является ли символ оператором
        /// </summary>
        /// <param name="item">Символ, который необходимо проверить</param>
        /// <returns>Возвращает true, если символ не соответствует ни одной операции</returns>
        private bool IsNotOperation(char item)
        {
            if (!(item == 'D' || item == 'M' || item == 'S' || item == 'I' || item == ',' || item == '(' || item == ')'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Метод, выполняющий проверку операндов на корректность. Для каждой операции первый
        /// операнд может быть строкой или символом, остальные - числа
        /// </summary>
        /// <returns>Возвращает true, если операнды введены корректно</returns>
        private bool ParameterCheck()
        {
            Stack<Operand> stack = new Stack<Operand>(operands);
            int stack_lenght = stack.Count;
            for(int i = 0; i < stack_lenght; i++)
            {
                Operand operand = stack.Pop();
                if (i == 0)
                {
                    if(!(operand.value is string) && !(operand.value is char))
                    {
                        return false;
                    }
                }
                else
                {
                    if(!(operand.value is int))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}