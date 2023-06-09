﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.Forms;
using KorisnickiInterfejs.ServerCommunication;

namespace KorisnickiInterfejs.GUIController
{
    public class RotablePartsController
    {
        FrmRotableParts rotableParts;
        internal void InitData(FrmRotableParts rotableParts)
        {

            try
            {
                this.rotableParts = rotableParts;
                rotableParts.DpDateOfEntry.CustomFormat = " ";
            }
            catch (ServerCommunicationException)
            {
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                rotableParts.Dispose();
                rotableParts = null;
            }
        }

        internal void GetCard()
        {
            if (!SearchValidation())
            {
                MessageBox.Show("Unos podataka nije validan!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }

            try
            {
                RotableParts RotableParts = new RotableParts
                {
                    PartNumber = rotableParts.TxtPartNumber.Text,
                    SerialNumber = rotableParts.TxtSerialNumber.Text
                };
                if (NadjiKarton(RotableParts) != null)
                { 
                    MessageBox.Show("Sistem je našao karton dijela u evidenciji avio dijelova!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    rotableParts.Dispose();
                    rotableParts = null;
                }
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da nađe karton dijela u evidenciji avio dijelova!", "System Operation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show("Sistem je spreman za unos kartona avionskog dijela!", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                rotableParts.BtnAddRotablePartsItem.Enabled = true;
                rotableParts.BtnCancel.Enabled = true;
                rotableParts.BtnSearchForItem.Enabled = false;
                rotableParts.DpDateOfEntry.CustomFormat = "dd/MM/yyyy HH:mm";
                rotableParts.DpDateOfEntry.Value = DateTime.Now;
                rotableParts.TxtPartNumber.ReadOnly = true;
                rotableParts.TxtSerialNumber.ReadOnly = true;
            }
        }     

        internal void SaveCard()
        {
            try
            {
                if (!Validation())
                {
                    MessageBox.Show("Unos podataka nije validan!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }

                RotablePartsLog rotablePartsLog = new RotablePartsLog
                {
                    RotableParts = new RotableParts
                    {
                        PartNumber = rotableParts.TxtPartNumber.Text,
                        SerialNumber = rotableParts.TxtSerialNumber.Text,
                        Description = rotableParts.RtbDescription.Text,
                        TableNameIndex = 1
                    },
                    SubClass = (int)SubClass.Stock,
                    TableNameIndex = 1,
                    RotablePartsSubClass = new RotablePartsStock
                    {
                        RotablePartsLog = new RotablePartsLog(),
                        RotableParts = new RotableParts(),
                        DateOfEntry = DateTime.Parse(rotableParts.DpDateOfEntry.Text),
                        HoursOperationalLimit = decimal.Parse(rotableParts.TxtHoursOperationalLimit.Text),
                        CyclesOperationalLimit = decimal.Parse(rotableParts.TxtCyclesOperationalLimit.Text),
                        DaysOperationalLimit = decimal.Parse(rotableParts.TxtDaysOperationalLimit.Text),
                        StorageLimit = decimal.Parse(rotableParts.TxtStorageLimit.Text),
                        TimeSinceNew = decimal.Parse(rotableParts.TxtTimeSinceNew.Text),
                        CyclesSinceNew = decimal.Parse(rotableParts.TxtCyclesSinceNew.Text),
                        DaysSinceNew = decimal.Parse(rotableParts.TxtDaysSinceNew.Text),
                        TimeSinceOverhaul = decimal.Parse(rotableParts.TxtTimeSinceOverhaul.Text),
                        CyclesSinceOverhaul = decimal.Parse(rotableParts.TxtCyclesSinceOverhaul.Text),
                        DaysSinceOverhaul = decimal.Parse(rotableParts.TxtDaysSinceOverhaul.Text),
                        ExpireAtDate = DateTime.Parse(rotableParts.DpDateOfEntry.Text).AddDays(double.Parse(rotableParts.TxtStorageLimit.Text)),
                        IsInitial = true,
                        TableNameIndex = 1,
                    }

                };
                rotablePartsLog = ZapamtiKarton(rotablePartsLog);
                MessageBox.Show("Sistem je dodao karton dijela u evidenciju avio dijelova!", "System Operation is successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                ClearComponent();
            }

            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da sačuva karton dijela u evidenciju avio dijelova!", "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                throw new ServerCommunicationException("Veza sa serverom ne postoji!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message, "System Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                rotableParts.Dispose();
                rotableParts = null;
            }
        }

        internal void ClearComponent()
        {
            rotableParts.TxtPartNumber.Text = string.Empty;
            rotableParts.TxtSerialNumber.Text = string.Empty;
            rotableParts.RtbDescription.Text = string.Empty;
            rotableParts.DpDateOfEntry.Value = DateTime.Now;
            rotableParts.TxtHoursOperationalLimit.Text = string.Empty;
            rotableParts.TxtCyclesOperationalLimit.Text = string.Empty;
            rotableParts.TxtDaysOperationalLimit.Text = string.Empty;
            rotableParts.TxtStorageLimit.Text = string.Empty;
            rotableParts.TxtTimeSinceNew.Text = string.Empty;
            rotableParts.TxtCyclesSinceNew.Text = string.Empty;
            rotableParts.TxtDaysSinceNew.Text = string.Empty;
            rotableParts.TxtTimeSinceOverhaul.Text = string.Empty;
            rotableParts.TxtCyclesSinceOverhaul.Text = string.Empty;
            rotableParts.TxtDaysSinceOverhaul.Text = string.Empty;
            rotableParts.BtnCancel.Enabled = false;
            rotableParts.BtnAddRotablePartsItem.Enabled = false;
            rotableParts.BtnSearchForItem.Enabled = true;
            rotableParts.DpDateOfEntry.CustomFormat = " ";
            rotableParts.TxtPartNumber.ReadOnly = false;
            rotableParts.TxtSerialNumber.ReadOnly = false;

        }

        private bool Validation()
        {
            if (rotableParts.TxtPartNumber.Text == string.Empty) return false;
            if (rotableParts.TxtSerialNumber.Text == string.Empty) return false;
            if (rotableParts.RtbDescription.Text == string.Empty) return false;

            if (!DateTime.TryParse(rotableParts.DpDateOfEntry.Text, out _)) return false;
            if (!decimal.TryParse(rotableParts.TxtHoursOperationalLimit.Text, out _)) return false;
            if (!decimal.TryParse(rotableParts.TxtCyclesOperationalLimit.Text, out _)) return false; 
            if (!decimal.TryParse(rotableParts.TxtDaysOperationalLimit.Text, out _)) return false;
            if (!decimal.TryParse(rotableParts.TxtStorageLimit.Text, out _)) return false;
            if (!decimal.TryParse(rotableParts.TxtTimeSinceNew.Text, out _)) return false;
            if (!decimal.TryParse(rotableParts.TxtCyclesSinceNew.Text, out _)) return false;
            if (!decimal.TryParse(rotableParts.TxtDaysSinceNew.Text, out _)) return false;
            if (!decimal.TryParse(rotableParts.TxtTimeSinceOverhaul.Text, out _)) return false;
            if (!decimal.TryParse(rotableParts.TxtCyclesSinceOverhaul.Text, out _)) return false;
            if (!decimal.TryParse(rotableParts.TxtDaysSinceOverhaul.Text, out _)) return false;
 
            return true;
        }

        private bool SearchValidation()
        {
            if (rotableParts.TxtPartNumber.Text == string.Empty) return false;
            if (rotableParts.TxtSerialNumber.Text == string.Empty) return false;

            return true;
        }

        private RotableParts NadjiKarton(RotableParts rotableParts)
        {
            return Communication.Instance.SendRequest<RotableParts>(Operation.SearchRotableParts, rotableParts);
        }

        private RotablePartsLog ZapamtiKarton(RotablePartsLog rotablePartsLog)
        {
            return Communication.Instance.SendRequest<RotablePartsLog>(Operation.AddRotableParts, rotablePartsLog);
        }
    }
}





