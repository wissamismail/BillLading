namespace BillLading
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label annexedDocmentsLabel;
            System.Windows.Forms.Label carrierLabel;
            System.Windows.Forms.Label carrierAddressLabel;
            System.Windows.Forms.Label carrierPhoneLabel;
            System.Windows.Forms.Label customsDeclarationNoLabel;
            System.Windows.Forms.Label dateOfIssueLabel;
            System.Windows.Forms.Label deliveryGoodsDateLabel;
            System.Windows.Forms.Label deliveryGoodsPlaceLabel;
            System.Windows.Forms.Label forwarderLabel;
            System.Windows.Forms.Label forwarderAddressLabel;
            System.Windows.Forms.Label forwarderObservationLabel;
            System.Windows.Forms.Label forwarderPhoneLabel;
            System.Windows.Forms.Label ladingIDLabel;
            System.Windows.Forms.Label placeOfIssueLabel;
            System.Windows.Forms.Label receiverLabel;
            System.Windows.Forms.Label receiverAddressLabel;
            System.Windows.Forms.Label receiverPhoneLabel;
            System.Windows.Forms.Label routeFinalDestinationLabel;
            System.Windows.Forms.Label senderLabel;
            System.Windows.Forms.Label senderAddressLabel;
            System.Windows.Forms.Label senderPhoneLabel;
            System.Windows.Forms.Label takingOverGoodsDateLabel;
            System.Windows.Forms.Label takingOverGoodsPlaceLabel;
            System.Windows.Forms.Label vehicleClassLabel;
            System.Windows.Forms.Label vehicleDriverLabel;
            System.Windows.Forms.Label vehicleNumberLabel;
            System.Windows.Forms.Label vehicleTypeLabel;
            this.annexedDocmentsTextBox = new System.Windows.Forms.TextBox();
            this.carrierTextBox = new System.Windows.Forms.TextBox();
            this.carrierAddressTextBox = new System.Windows.Forms.TextBox();
            this.carrierPhoneTextBox = new System.Windows.Forms.TextBox();
            this.customsDeclarationNoTextBox = new System.Windows.Forms.TextBox();
            this.dateOfIssueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deliveryGoodsDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deliveryGoodsPlaceTextBox = new System.Windows.Forms.TextBox();
            this.forwarderTextBox = new System.Windows.Forms.TextBox();
            this.forwarderAddressTextBox = new System.Windows.Forms.TextBox();
            this.forwarderObservationTextBox = new System.Windows.Forms.TextBox();
            this.forwarderPhoneTextBox = new System.Windows.Forms.TextBox();
            this.ladingIDTextBox = new System.Windows.Forms.TextBox();
            this.placeOfIssueTextBox = new System.Windows.Forms.TextBox();
            this.receiverTextBox = new System.Windows.Forms.TextBox();
            this.receiverAddressTextBox = new System.Windows.Forms.TextBox();
            this.receiverPhoneTextBox = new System.Windows.Forms.TextBox();
            this.routeFinalDestinationTextBox = new System.Windows.Forms.TextBox();
            this.senderTextBox = new System.Windows.Forms.TextBox();
            this.senderAddressTextBox = new System.Windows.Forms.TextBox();
            this.senderPhoneTextBox = new System.Windows.Forms.TextBox();
            this.takingOverGoodsDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.takingOverGoodsPlaceTextBox = new System.Windows.Forms.TextBox();
            this.vehicleClassTextBox = new System.Windows.Forms.TextBox();
            this.vehicleDriverTextBox = new System.Windows.Forms.TextBox();
            this.vehicleNumberTextBox = new System.Windows.Forms.TextBox();
            this.vehicleTypeTextBox = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.binSrcLading = new System.Windows.Forms.BindingSource(this.components);
            annexedDocmentsLabel = new System.Windows.Forms.Label();
            carrierLabel = new System.Windows.Forms.Label();
            carrierAddressLabel = new System.Windows.Forms.Label();
            carrierPhoneLabel = new System.Windows.Forms.Label();
            customsDeclarationNoLabel = new System.Windows.Forms.Label();
            dateOfIssueLabel = new System.Windows.Forms.Label();
            deliveryGoodsDateLabel = new System.Windows.Forms.Label();
            deliveryGoodsPlaceLabel = new System.Windows.Forms.Label();
            forwarderLabel = new System.Windows.Forms.Label();
            forwarderAddressLabel = new System.Windows.Forms.Label();
            forwarderObservationLabel = new System.Windows.Forms.Label();
            forwarderPhoneLabel = new System.Windows.Forms.Label();
            ladingIDLabel = new System.Windows.Forms.Label();
            placeOfIssueLabel = new System.Windows.Forms.Label();
            receiverLabel = new System.Windows.Forms.Label();
            receiverAddressLabel = new System.Windows.Forms.Label();
            receiverPhoneLabel = new System.Windows.Forms.Label();
            routeFinalDestinationLabel = new System.Windows.Forms.Label();
            senderLabel = new System.Windows.Forms.Label();
            senderAddressLabel = new System.Windows.Forms.Label();
            senderPhoneLabel = new System.Windows.Forms.Label();
            takingOverGoodsDateLabel = new System.Windows.Forms.Label();
            takingOverGoodsPlaceLabel = new System.Windows.Forms.Label();
            vehicleClassLabel = new System.Windows.Forms.Label();
            vehicleDriverLabel = new System.Windows.Forms.Label();
            vehicleNumberLabel = new System.Windows.Forms.Label();
            vehicleTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.binSrcLading)).BeginInit();
            this.SuspendLayout();
            // 
            // annexedDocmentsLabel
            // 
            annexedDocmentsLabel.AutoSize = true;
            annexedDocmentsLabel.Location = new System.Drawing.Point(611, 46);
            annexedDocmentsLabel.Name = "annexedDocmentsLabel";
            annexedDocmentsLabel.Size = new System.Drawing.Size(104, 13);
            annexedDocmentsLabel.TabIndex = 0;
            annexedDocmentsLabel.Text = "Annexed Docments:";
            // 
            // annexedDocmentsTextBox
            // 
            this.annexedDocmentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "AnnexedDocments", true));
            this.annexedDocmentsTextBox.Location = new System.Drawing.Point(747, 43);
            this.annexedDocmentsTextBox.Name = "annexedDocmentsTextBox";
            this.annexedDocmentsTextBox.Size = new System.Drawing.Size(200, 20);
            this.annexedDocmentsTextBox.TabIndex = 1;
            // 
            // carrierLabel
            // 
            carrierLabel.AutoSize = true;
            carrierLabel.Location = new System.Drawing.Point(611, 72);
            carrierLabel.Name = "carrierLabel";
            carrierLabel.Size = new System.Drawing.Size(44, 13);
            carrierLabel.TabIndex = 2;
            carrierLabel.Text = "Carrier:";
            // 
            // carrierTextBox
            // 
            this.carrierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "Carrier", true));
            this.carrierTextBox.Location = new System.Drawing.Point(747, 69);
            this.carrierTextBox.Name = "carrierTextBox";
            this.carrierTextBox.Size = new System.Drawing.Size(200, 20);
            this.carrierTextBox.TabIndex = 3;
            // 
            // carrierAddressLabel
            // 
            carrierAddressLabel.AutoSize = true;
            carrierAddressLabel.Location = new System.Drawing.Point(611, 98);
            carrierAddressLabel.Name = "carrierAddressLabel";
            carrierAddressLabel.Size = new System.Drawing.Size(86, 13);
            carrierAddressLabel.TabIndex = 4;
            carrierAddressLabel.Text = "Carrier Address:";
            // 
            // carrierAddressTextBox
            // 
            this.carrierAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "CarrierAddress", true));
            this.carrierAddressTextBox.Location = new System.Drawing.Point(747, 95);
            this.carrierAddressTextBox.Name = "carrierAddressTextBox";
            this.carrierAddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.carrierAddressTextBox.TabIndex = 5;
            // 
            // carrierPhoneLabel
            // 
            carrierPhoneLabel.AutoSize = true;
            carrierPhoneLabel.Location = new System.Drawing.Point(611, 124);
            carrierPhoneLabel.Name = "carrierPhoneLabel";
            carrierPhoneLabel.Size = new System.Drawing.Size(77, 13);
            carrierPhoneLabel.TabIndex = 6;
            carrierPhoneLabel.Text = "Carrier Phone:";
            // 
            // carrierPhoneTextBox
            // 
            this.carrierPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "CarrierPhone", true));
            this.carrierPhoneTextBox.Location = new System.Drawing.Point(747, 121);
            this.carrierPhoneTextBox.Name = "carrierPhoneTextBox";
            this.carrierPhoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.carrierPhoneTextBox.TabIndex = 7;
            // 
            // customsDeclarationNoLabel
            // 
            customsDeclarationNoLabel.AutoSize = true;
            customsDeclarationNoLabel.Location = new System.Drawing.Point(611, 150);
            customsDeclarationNoLabel.Name = "customsDeclarationNoLabel";
            customsDeclarationNoLabel.Size = new System.Drawing.Size(125, 13);
            customsDeclarationNoLabel.TabIndex = 8;
            customsDeclarationNoLabel.Text = "Customs Declaration No:";
            // 
            // customsDeclarationNoTextBox
            // 
            this.customsDeclarationNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "CustomsDeclarationNo", true));
            this.customsDeclarationNoTextBox.Location = new System.Drawing.Point(747, 147);
            this.customsDeclarationNoTextBox.Name = "customsDeclarationNoTextBox";
            this.customsDeclarationNoTextBox.Size = new System.Drawing.Size(200, 20);
            this.customsDeclarationNoTextBox.TabIndex = 9;
            // 
            // dateOfIssueLabel
            // 
            dateOfIssueLabel.AutoSize = true;
            dateOfIssueLabel.Location = new System.Drawing.Point(611, 177);
            dateOfIssueLabel.Name = "dateOfIssueLabel";
            dateOfIssueLabel.Size = new System.Drawing.Size(78, 13);
            dateOfIssueLabel.TabIndex = 10;
            dateOfIssueLabel.Text = "Date Of Issue:";
            // 
            // dateOfIssueDateTimePicker
            // 
            this.dateOfIssueDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.binSrcLading, "DateOfIssue", true));
            this.dateOfIssueDateTimePicker.Location = new System.Drawing.Point(747, 173);
            this.dateOfIssueDateTimePicker.Name = "dateOfIssueDateTimePicker";
            this.dateOfIssueDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfIssueDateTimePicker.TabIndex = 11;
            // 
            // deliveryGoodsDateLabel
            // 
            deliveryGoodsDateLabel.AutoSize = true;
            deliveryGoodsDateLabel.Location = new System.Drawing.Point(611, 203);
            deliveryGoodsDateLabel.Name = "deliveryGoodsDateLabel";
            deliveryGoodsDateLabel.Size = new System.Drawing.Size(109, 13);
            deliveryGoodsDateLabel.TabIndex = 12;
            deliveryGoodsDateLabel.Text = "Delivery Goods Date:";
            // 
            // deliveryGoodsDateDateTimePicker
            // 
            this.deliveryGoodsDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.binSrcLading, "DeliveryGoodsDate", true));
            this.deliveryGoodsDateDateTimePicker.Location = new System.Drawing.Point(747, 199);
            this.deliveryGoodsDateDateTimePicker.Name = "deliveryGoodsDateDateTimePicker";
            this.deliveryGoodsDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.deliveryGoodsDateDateTimePicker.TabIndex = 13;
            // 
            // deliveryGoodsPlaceLabel
            // 
            deliveryGoodsPlaceLabel.AutoSize = true;
            deliveryGoodsPlaceLabel.Location = new System.Drawing.Point(611, 228);
            deliveryGoodsPlaceLabel.Name = "deliveryGoodsPlaceLabel";
            deliveryGoodsPlaceLabel.Size = new System.Drawing.Size(111, 13);
            deliveryGoodsPlaceLabel.TabIndex = 14;
            deliveryGoodsPlaceLabel.Text = "Delivery Goods Place:";
            // 
            // deliveryGoodsPlaceTextBox
            // 
            this.deliveryGoodsPlaceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "DeliveryGoodsPlace", true));
            this.deliveryGoodsPlaceTextBox.Location = new System.Drawing.Point(747, 225);
            this.deliveryGoodsPlaceTextBox.Name = "deliveryGoodsPlaceTextBox";
            this.deliveryGoodsPlaceTextBox.Size = new System.Drawing.Size(200, 20);
            this.deliveryGoodsPlaceTextBox.TabIndex = 15;
            // 
            // forwarderLabel
            // 
            forwarderLabel.AutoSize = true;
            forwarderLabel.Location = new System.Drawing.Point(611, 254);
            forwarderLabel.Name = "forwarderLabel";
            forwarderLabel.Size = new System.Drawing.Size(61, 13);
            forwarderLabel.TabIndex = 16;
            forwarderLabel.Text = "Forwarder:";
            // 
            // forwarderTextBox
            // 
            this.forwarderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "Forwarder", true));
            this.forwarderTextBox.Location = new System.Drawing.Point(747, 251);
            this.forwarderTextBox.Name = "forwarderTextBox";
            this.forwarderTextBox.Size = new System.Drawing.Size(200, 20);
            this.forwarderTextBox.TabIndex = 17;
            // 
            // forwarderAddressLabel
            // 
            forwarderAddressLabel.AutoSize = true;
            forwarderAddressLabel.Location = new System.Drawing.Point(611, 280);
            forwarderAddressLabel.Name = "forwarderAddressLabel";
            forwarderAddressLabel.Size = new System.Drawing.Size(103, 13);
            forwarderAddressLabel.TabIndex = 18;
            forwarderAddressLabel.Text = "Forwarder Address:";
            // 
            // forwarderAddressTextBox
            // 
            this.forwarderAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "ForwarderAddress", true));
            this.forwarderAddressTextBox.Location = new System.Drawing.Point(747, 277);
            this.forwarderAddressTextBox.Name = "forwarderAddressTextBox";
            this.forwarderAddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.forwarderAddressTextBox.TabIndex = 19;
            // 
            // forwarderObservationLabel
            // 
            forwarderObservationLabel.AutoSize = true;
            forwarderObservationLabel.Location = new System.Drawing.Point(611, 306);
            forwarderObservationLabel.Name = "forwarderObservationLabel";
            forwarderObservationLabel.Size = new System.Drawing.Size(123, 13);
            forwarderObservationLabel.TabIndex = 20;
            forwarderObservationLabel.Text = "Forwarder Observation:";
            // 
            // forwarderObservationTextBox
            // 
            this.forwarderObservationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "ForwarderObservation", true));
            this.forwarderObservationTextBox.Location = new System.Drawing.Point(747, 303);
            this.forwarderObservationTextBox.Name = "forwarderObservationTextBox";
            this.forwarderObservationTextBox.Size = new System.Drawing.Size(200, 20);
            this.forwarderObservationTextBox.TabIndex = 21;
            // 
            // forwarderPhoneLabel
            // 
            forwarderPhoneLabel.AutoSize = true;
            forwarderPhoneLabel.Location = new System.Drawing.Point(611, 332);
            forwarderPhoneLabel.Name = "forwarderPhoneLabel";
            forwarderPhoneLabel.Size = new System.Drawing.Size(94, 13);
            forwarderPhoneLabel.TabIndex = 22;
            forwarderPhoneLabel.Text = "Forwarder Phone:";
            // 
            // forwarderPhoneTextBox
            // 
            this.forwarderPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "ForwarderPhone", true));
            this.forwarderPhoneTextBox.Location = new System.Drawing.Point(747, 329);
            this.forwarderPhoneTextBox.Name = "forwarderPhoneTextBox";
            this.forwarderPhoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.forwarderPhoneTextBox.TabIndex = 23;
            // 
            // ladingIDLabel
            // 
            ladingIDLabel.AutoSize = true;
            ladingIDLabel.Location = new System.Drawing.Point(611, 358);
            ladingIDLabel.Name = "ladingIDLabel";
            ladingIDLabel.Size = new System.Drawing.Size(56, 13);
            ladingIDLabel.TabIndex = 24;
            ladingIDLabel.Text = "Lading ID:";
            // 
            // ladingIDTextBox
            // 
            this.ladingIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "LadingID", true));
            this.ladingIDTextBox.Location = new System.Drawing.Point(747, 355);
            this.ladingIDTextBox.Name = "ladingIDTextBox";
            this.ladingIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.ladingIDTextBox.TabIndex = 25;
            // 
            // placeOfIssueLabel
            // 
            placeOfIssueLabel.AutoSize = true;
            placeOfIssueLabel.Location = new System.Drawing.Point(611, 384);
            placeOfIssueLabel.Name = "placeOfIssueLabel";
            placeOfIssueLabel.Size = new System.Drawing.Size(80, 13);
            placeOfIssueLabel.TabIndex = 26;
            placeOfIssueLabel.Text = "Place Of Issue:";
            // 
            // placeOfIssueTextBox
            // 
            this.placeOfIssueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "PlaceOfIssue", true));
            this.placeOfIssueTextBox.Location = new System.Drawing.Point(747, 381);
            this.placeOfIssueTextBox.Name = "placeOfIssueTextBox";
            this.placeOfIssueTextBox.Size = new System.Drawing.Size(200, 20);
            this.placeOfIssueTextBox.TabIndex = 27;
            // 
            // receiverLabel
            // 
            receiverLabel.AutoSize = true;
            receiverLabel.Location = new System.Drawing.Point(611, 410);
            receiverLabel.Name = "receiverLabel";
            receiverLabel.Size = new System.Drawing.Size(53, 13);
            receiverLabel.TabIndex = 28;
            receiverLabel.Text = "Receiver:";
            // 
            // receiverTextBox
            // 
            this.receiverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "Receiver", true));
            this.receiverTextBox.Location = new System.Drawing.Point(747, 407);
            this.receiverTextBox.Name = "receiverTextBox";
            this.receiverTextBox.Size = new System.Drawing.Size(200, 20);
            this.receiverTextBox.TabIndex = 29;
            // 
            // receiverAddressLabel
            // 
            receiverAddressLabel.AutoSize = true;
            receiverAddressLabel.Location = new System.Drawing.Point(611, 436);
            receiverAddressLabel.Name = "receiverAddressLabel";
            receiverAddressLabel.Size = new System.Drawing.Size(95, 13);
            receiverAddressLabel.TabIndex = 30;
            receiverAddressLabel.Text = "Receiver Address:";
            // 
            // receiverAddressTextBox
            // 
            this.receiverAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "ReceiverAddress", true));
            this.receiverAddressTextBox.Location = new System.Drawing.Point(747, 433);
            this.receiverAddressTextBox.Name = "receiverAddressTextBox";
            this.receiverAddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.receiverAddressTextBox.TabIndex = 31;
            // 
            // receiverPhoneLabel
            // 
            receiverPhoneLabel.AutoSize = true;
            receiverPhoneLabel.Location = new System.Drawing.Point(611, 462);
            receiverPhoneLabel.Name = "receiverPhoneLabel";
            receiverPhoneLabel.Size = new System.Drawing.Size(86, 13);
            receiverPhoneLabel.TabIndex = 32;
            receiverPhoneLabel.Text = "Receiver Phone:";
            // 
            // receiverPhoneTextBox
            // 
            this.receiverPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "ReceiverPhone", true));
            this.receiverPhoneTextBox.Location = new System.Drawing.Point(747, 459);
            this.receiverPhoneTextBox.Name = "receiverPhoneTextBox";
            this.receiverPhoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.receiverPhoneTextBox.TabIndex = 33;
            // 
            // routeFinalDestinationLabel
            // 
            routeFinalDestinationLabel.AutoSize = true;
            routeFinalDestinationLabel.Location = new System.Drawing.Point(611, 488);
            routeFinalDestinationLabel.Name = "routeFinalDestinationLabel";
            routeFinalDestinationLabel.Size = new System.Drawing.Size(122, 13);
            routeFinalDestinationLabel.TabIndex = 34;
            routeFinalDestinationLabel.Text = "Route Final Destination:";
            // 
            // routeFinalDestinationTextBox
            // 
            this.routeFinalDestinationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "RouteFinalDestination", true));
            this.routeFinalDestinationTextBox.Location = new System.Drawing.Point(747, 485);
            this.routeFinalDestinationTextBox.Name = "routeFinalDestinationTextBox";
            this.routeFinalDestinationTextBox.Size = new System.Drawing.Size(200, 20);
            this.routeFinalDestinationTextBox.TabIndex = 35;
            // 
            // senderLabel
            // 
            senderLabel.AutoSize = true;
            senderLabel.Location = new System.Drawing.Point(611, 514);
            senderLabel.Name = "senderLabel";
            senderLabel.Size = new System.Drawing.Size(45, 13);
            senderLabel.TabIndex = 36;
            senderLabel.Text = "Sender:";
            // 
            // senderTextBox
            // 
            this.senderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "Sender", true));
            this.senderTextBox.Location = new System.Drawing.Point(747, 511);
            this.senderTextBox.Name = "senderTextBox";
            this.senderTextBox.Size = new System.Drawing.Size(200, 20);
            this.senderTextBox.TabIndex = 37;
            // 
            // senderAddressLabel
            // 
            senderAddressLabel.AutoSize = true;
            senderAddressLabel.Location = new System.Drawing.Point(611, 540);
            senderAddressLabel.Name = "senderAddressLabel";
            senderAddressLabel.Size = new System.Drawing.Size(87, 13);
            senderAddressLabel.TabIndex = 38;
            senderAddressLabel.Text = "Sender Address:";
            // 
            // senderAddressTextBox
            // 
            this.senderAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "SenderAddress", true));
            this.senderAddressTextBox.Location = new System.Drawing.Point(747, 537);
            this.senderAddressTextBox.Name = "senderAddressTextBox";
            this.senderAddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.senderAddressTextBox.TabIndex = 39;
            // 
            // senderPhoneLabel
            // 
            senderPhoneLabel.AutoSize = true;
            senderPhoneLabel.Location = new System.Drawing.Point(611, 566);
            senderPhoneLabel.Name = "senderPhoneLabel";
            senderPhoneLabel.Size = new System.Drawing.Size(78, 13);
            senderPhoneLabel.TabIndex = 40;
            senderPhoneLabel.Text = "Sender Phone:";
            // 
            // senderPhoneTextBox
            // 
            this.senderPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "SenderPhone", true));
            this.senderPhoneTextBox.Location = new System.Drawing.Point(747, 563);
            this.senderPhoneTextBox.Name = "senderPhoneTextBox";
            this.senderPhoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.senderPhoneTextBox.TabIndex = 41;
            // 
            // takingOverGoodsDateLabel
            // 
            takingOverGoodsDateLabel.AutoSize = true;
            takingOverGoodsDateLabel.Location = new System.Drawing.Point(611, 593);
            takingOverGoodsDateLabel.Name = "takingOverGoodsDateLabel";
            takingOverGoodsDateLabel.Size = new System.Drawing.Size(128, 13);
            takingOverGoodsDateLabel.TabIndex = 42;
            takingOverGoodsDateLabel.Text = "Taking Over Goods Date:";
            // 
            // takingOverGoodsDateDateTimePicker
            // 
            this.takingOverGoodsDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.binSrcLading, "TakingOverGoodsDate", true));
            this.takingOverGoodsDateDateTimePicker.Location = new System.Drawing.Point(747, 589);
            this.takingOverGoodsDateDateTimePicker.Name = "takingOverGoodsDateDateTimePicker";
            this.takingOverGoodsDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.takingOverGoodsDateDateTimePicker.TabIndex = 43;
            // 
            // takingOverGoodsPlaceLabel
            // 
            takingOverGoodsPlaceLabel.AutoSize = true;
            takingOverGoodsPlaceLabel.Location = new System.Drawing.Point(611, 618);
            takingOverGoodsPlaceLabel.Name = "takingOverGoodsPlaceLabel";
            takingOverGoodsPlaceLabel.Size = new System.Drawing.Size(130, 13);
            takingOverGoodsPlaceLabel.TabIndex = 44;
            takingOverGoodsPlaceLabel.Text = "Taking Over Goods Place:";
            // 
            // takingOverGoodsPlaceTextBox
            // 
            this.takingOverGoodsPlaceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "TakingOverGoodsPlace", true));
            this.takingOverGoodsPlaceTextBox.Location = new System.Drawing.Point(747, 615);
            this.takingOverGoodsPlaceTextBox.Name = "takingOverGoodsPlaceTextBox";
            this.takingOverGoodsPlaceTextBox.Size = new System.Drawing.Size(200, 20);
            this.takingOverGoodsPlaceTextBox.TabIndex = 45;
            // 
            // vehicleClassLabel
            // 
            vehicleClassLabel.AutoSize = true;
            vehicleClassLabel.Location = new System.Drawing.Point(611, 644);
            vehicleClassLabel.Name = "vehicleClassLabel";
            vehicleClassLabel.Size = new System.Drawing.Size(72, 13);
            vehicleClassLabel.TabIndex = 46;
            vehicleClassLabel.Text = "Vehicle Class:";
            // 
            // vehicleClassTextBox
            // 
            this.vehicleClassTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "VehicleClass", true));
            this.vehicleClassTextBox.Location = new System.Drawing.Point(747, 641);
            this.vehicleClassTextBox.Name = "vehicleClassTextBox";
            this.vehicleClassTextBox.Size = new System.Drawing.Size(200, 20);
            this.vehicleClassTextBox.TabIndex = 47;
            // 
            // vehicleDriverLabel
            // 
            vehicleDriverLabel.AutoSize = true;
            vehicleDriverLabel.Location = new System.Drawing.Point(611, 670);
            vehicleDriverLabel.Name = "vehicleDriverLabel";
            vehicleDriverLabel.Size = new System.Drawing.Size(76, 13);
            vehicleDriverLabel.TabIndex = 48;
            vehicleDriverLabel.Text = "Vehicle Driver:";
            // 
            // vehicleDriverTextBox
            // 
            this.vehicleDriverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "VehicleDriver", true));
            this.vehicleDriverTextBox.Location = new System.Drawing.Point(747, 667);
            this.vehicleDriverTextBox.Name = "vehicleDriverTextBox";
            this.vehicleDriverTextBox.Size = new System.Drawing.Size(200, 20);
            this.vehicleDriverTextBox.TabIndex = 49;
            // 
            // vehicleNumberLabel
            // 
            vehicleNumberLabel.AutoSize = true;
            vehicleNumberLabel.Location = new System.Drawing.Point(611, 696);
            vehicleNumberLabel.Name = "vehicleNumberLabel";
            vehicleNumberLabel.Size = new System.Drawing.Size(84, 13);
            vehicleNumberLabel.TabIndex = 50;
            vehicleNumberLabel.Text = "Vehicle Number:";
            // 
            // vehicleNumberTextBox
            // 
            this.vehicleNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "VehicleNumber", true));
            this.vehicleNumberTextBox.Location = new System.Drawing.Point(747, 693);
            this.vehicleNumberTextBox.Name = "vehicleNumberTextBox";
            this.vehicleNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.vehicleNumberTextBox.TabIndex = 51;
            // 
            // vehicleTypeLabel
            // 
            vehicleTypeLabel.AutoSize = true;
            vehicleTypeLabel.Location = new System.Drawing.Point(611, 722);
            vehicleTypeLabel.Name = "vehicleTypeLabel";
            vehicleTypeLabel.Size = new System.Drawing.Size(71, 13);
            vehicleTypeLabel.TabIndex = 52;
            vehicleTypeLabel.Text = "Vehicle Type:";
            // 
            // vehicleTypeTextBox
            // 
            this.vehicleTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.binSrcLading, "VehicleType", true));
            this.vehicleTypeTextBox.Location = new System.Drawing.Point(747, 719);
            this.vehicleTypeTextBox.Name = "vehicleTypeTextBox";
            this.vehicleTypeTextBox.Size = new System.Drawing.Size(200, 20);
            this.vehicleTypeTextBox.TabIndex = 53;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(49, 69);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 54;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(49, 93);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 54;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(49, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(49, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(49, 170);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "إلغاء الأمر";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // binSrcLading
            // 
            this.binSrcLading.DataSource = typeof(BillLading.Lading);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 759);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(annexedDocmentsLabel);
            this.Controls.Add(this.annexedDocmentsTextBox);
            this.Controls.Add(carrierLabel);
            this.Controls.Add(this.carrierTextBox);
            this.Controls.Add(carrierAddressLabel);
            this.Controls.Add(this.carrierAddressTextBox);
            this.Controls.Add(carrierPhoneLabel);
            this.Controls.Add(this.carrierPhoneTextBox);
            this.Controls.Add(customsDeclarationNoLabel);
            this.Controls.Add(this.customsDeclarationNoTextBox);
            this.Controls.Add(dateOfIssueLabel);
            this.Controls.Add(this.dateOfIssueDateTimePicker);
            this.Controls.Add(deliveryGoodsDateLabel);
            this.Controls.Add(this.deliveryGoodsDateDateTimePicker);
            this.Controls.Add(deliveryGoodsPlaceLabel);
            this.Controls.Add(this.deliveryGoodsPlaceTextBox);
            this.Controls.Add(forwarderLabel);
            this.Controls.Add(this.forwarderTextBox);
            this.Controls.Add(forwarderAddressLabel);
            this.Controls.Add(this.forwarderAddressTextBox);
            this.Controls.Add(forwarderObservationLabel);
            this.Controls.Add(this.forwarderObservationTextBox);
            this.Controls.Add(forwarderPhoneLabel);
            this.Controls.Add(this.forwarderPhoneTextBox);
            this.Controls.Add(ladingIDLabel);
            this.Controls.Add(this.ladingIDTextBox);
            this.Controls.Add(placeOfIssueLabel);
            this.Controls.Add(this.placeOfIssueTextBox);
            this.Controls.Add(receiverLabel);
            this.Controls.Add(this.receiverTextBox);
            this.Controls.Add(receiverAddressLabel);
            this.Controls.Add(this.receiverAddressTextBox);
            this.Controls.Add(receiverPhoneLabel);
            this.Controls.Add(this.receiverPhoneTextBox);
            this.Controls.Add(routeFinalDestinationLabel);
            this.Controls.Add(this.routeFinalDestinationTextBox);
            this.Controls.Add(senderLabel);
            this.Controls.Add(this.senderTextBox);
            this.Controls.Add(senderAddressLabel);
            this.Controls.Add(this.senderAddressTextBox);
            this.Controls.Add(senderPhoneLabel);
            this.Controls.Add(this.senderPhoneTextBox);
            this.Controls.Add(takingOverGoodsDateLabel);
            this.Controls.Add(this.takingOverGoodsDateDateTimePicker);
            this.Controls.Add(takingOverGoodsPlaceLabel);
            this.Controls.Add(this.takingOverGoodsPlaceTextBox);
            this.Controls.Add(vehicleClassLabel);
            this.Controls.Add(this.vehicleClassTextBox);
            this.Controls.Add(vehicleDriverLabel);
            this.Controls.Add(this.vehicleDriverTextBox);
            this.Controls.Add(vehicleNumberLabel);
            this.Controls.Add(this.vehicleNumberTextBox);
            this.Controls.Add(vehicleTypeLabel);
            this.Controls.Add(this.vehicleTypeTextBox);
            this.Name = "Form1";
            this.Text = "بوليصة شحن";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.binSrcLading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource binSrcLading;
        private System.Windows.Forms.TextBox annexedDocmentsTextBox;
        private System.Windows.Forms.TextBox carrierTextBox;
        private System.Windows.Forms.TextBox carrierAddressTextBox;
        private System.Windows.Forms.TextBox carrierPhoneTextBox;
        private System.Windows.Forms.TextBox customsDeclarationNoTextBox;
        private System.Windows.Forms.DateTimePicker dateOfIssueDateTimePicker;
        private System.Windows.Forms.DateTimePicker deliveryGoodsDateDateTimePicker;
        private System.Windows.Forms.TextBox deliveryGoodsPlaceTextBox;
        private System.Windows.Forms.TextBox forwarderTextBox;
        private System.Windows.Forms.TextBox forwarderAddressTextBox;
        private System.Windows.Forms.TextBox forwarderObservationTextBox;
        private System.Windows.Forms.TextBox forwarderPhoneTextBox;
        private System.Windows.Forms.TextBox ladingIDTextBox;
        private System.Windows.Forms.TextBox placeOfIssueTextBox;
        private System.Windows.Forms.TextBox receiverTextBox;
        private System.Windows.Forms.TextBox receiverAddressTextBox;
        private System.Windows.Forms.TextBox receiverPhoneTextBox;
        private System.Windows.Forms.TextBox routeFinalDestinationTextBox;
        private System.Windows.Forms.TextBox senderTextBox;
        private System.Windows.Forms.TextBox senderAddressTextBox;
        private System.Windows.Forms.TextBox senderPhoneTextBox;
        private System.Windows.Forms.DateTimePicker takingOverGoodsDateDateTimePicker;
        private System.Windows.Forms.TextBox takingOverGoodsPlaceTextBox;
        private System.Windows.Forms.TextBox vehicleClassTextBox;
        private System.Windows.Forms.TextBox vehicleDriverTextBox;
        private System.Windows.Forms.TextBox vehicleNumberTextBox;
        private System.Windows.Forms.TextBox vehicleTypeTextBox;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}

