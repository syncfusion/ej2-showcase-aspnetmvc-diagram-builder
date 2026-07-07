using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2;
using Newtonsoft.Json;
using NodeAnnotationIssue.Models;
using Syncfusion.EJ2.Popups;
using Syncfusion.EJ2.Diagrams;

namespace DiagramBuilder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DropDownDataModel fileItems = new DropDownDataModel();
            ViewBag.filemenuitems = fileItems.fileData();

            DropDownDataModel editItems = new DropDownDataModel();
            ViewBag.editmenuitems = editItems.editData();

            DropDownDataModel viewItems = new DropDownDataModel();
            ViewBag.viewmenuitems = viewItems.viewData();

            DropDownDataModel arrangeItems = new DropDownDataModel();
            ViewBag.arrangemenuitems = arrangeItems.arrangeData();

            DropDownDataModel windowItems = new DropDownDataModel();
            ViewBag.windowmenuitems = windowItems.windowData();

            DropDownDataModel helpItems = new DropDownDataModel();
            ViewBag.helpmenuitems = helpItems.helpData();

            DropDownDataModel zoomMenuItems = new DropDownDataModel();
            ViewBag.zoomMenuItems = zoomMenuItems.zoomMenuItems();

            DropDownDataModel drawShapesList = new DropDownDataModel();
            ViewBag.drawShapesList = drawShapesList.drawShapesList();

            DropDownDataModel drawConnectorsList = new DropDownDataModel();
            ViewBag.drawConnectorsList = drawShapesList.drawConnectorsList();

            DropDownDataModel orderCommandsList = new DropDownDataModel();
            ViewBag.orderCommandsList = orderCommandsList.orderCommandsList();

            DropDownDataModel paperList = new DropDownDataModel();
            ViewBag.paperList = paperList.paperList();

            DropDownDataModel gradientDirections = new DropDownDataModel();
            ViewBag.gradientDirections = gradientDirections.gradientDirections();

            DropDownDataModel borderStyles = new DropDownDataModel();
            ViewBag.borderStyles = borderStyles.borderStyles();

            DropDownDataModel fileFormats = new DropDownDataModel();
            ViewBag.fileFormats = fileFormats.fileFormats();

            DropDownDataModel diagramRegions = new DropDownDataModel();
            ViewBag.diagramRegions = diagramRegions.diagramRegions();

            DropDownDataModel lineTypes = new DropDownDataModel();
            ViewBag.lineTypes = lineTypes.lineTypes();

            DropDownDataModel decoratorList = new DropDownDataModel();
            ViewBag.decoratorList = decoratorList.decoratorList();

            DropDownDataModel fontFamilyList = new DropDownDataModel();
            ViewBag.fontFamilyList = fontFamilyList.fontFamilyList();

            DropDownDataModel textPosition = new DropDownDataModel();
            ViewBag.textPosition = textPosition.textPosition();

            DropDownDataModel mindmapLevels = new DropDownDataModel();
            ViewBag.mindmapLevels = mindmapLevels.mindmapLevels();

            DropDownDataModel listViewData = new DropDownDataModel();
            ViewBag.listViewData = listViewData.listViewData();

            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "btnMoreShapes", ButtonModel = new ButtonModel() { isPrimary = true, cssClass = "e-flat e-db-primary", content = "Apply" } });
            buttons.Add(new DialogDialogButton() { Click = "btnCancelClick", ButtonModel = new ButtonModel() { isPrimary = true, cssClass = "e-flat e-db-primary", content = "Cancel" } });
            ViewBag.DefaultButtons = buttons;

            List<DialogDialogButton> buttons1 = new List<DialogDialogButton>() { };
            buttons1.Add(new DialogDialogButton() { Click = "btnDeleteConfirmation", ButtonModel = new ButtonModel() { isPrimary = true, cssClass = "e-flat e-db-primary", content = "Ok" } });
            ViewBag.deleteconfirmation = buttons;

            ViewBag.tooltipButton = new ButtonModel() { isPrimary = true, cssClass = "e-flat e-db-primary", content = "Apply" };

            ViewBag.ExportButton = new ButtonModel() { isPrimary = true, cssClass = "e-flat e-db-primary", content = "Export" };

            ViewBag.PrintButton = new ButtonModel() { isPrimary = true, cssClass = "e-flat e-db-primary", content = "Print" };

            ViewBag.SaveButton = new ButtonModel() { isPrimary = true, cssClass = "e-flat e-db-primary", content = "Save" };

            ViewBag.hyperlink = new ButtonModel() { isPrimary = true, cssClass = "e-flat e-db-primary", content = "Apply" };

            ViewBag.deleteconfirmation = new ButtonModel() { isPrimary = true, cssClass = "e-flat e-db-primary", content = "Ok" };

            ViewBag.moreshapes = new ButtonModel() { isPrimary = true, cssClass = "e-flat e-db-primary", content = "Apply" };

            ViewBag.uplaodNext = new ButtonModel() { isPrimary = true, cssClass = "e-flat e-db-primary", content = "Next" };

            ViewBag.CancelClick = new ButtonModel() { isPrimary = true, cssClass = "e-flat e-db-primary", content = "Cancel" };

            List<DiagramNode> SymbolPaletee = new List<DiagramNode>();
            SymbolPaletee.Add(new DiagramNode() { Id = "Terminator", Shape = new { type = "Flow", shape = "Terminator" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "Process", Shape = new { type = "Flow", shape = "Process" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "Decision", Shape = new { type = "Flow", shape = "Decision" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "Document", Shape = new { type = "Flow", shape = "Document" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "PreDefinedProcess", Shape = new { type = "Flow", shape = "PreDefinedProcess" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "PaperTap", Shape = new { type = "Flow", shape = "PaperTap" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "DirectData", Shape = new { type = "Flow", shape = "DirectData" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "SequentialData", Shape = new { type = "Flow", shape = "SequentialData" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "Sort", Shape = new { type = "Flow", shape = "Sort" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "MultiDocument", Shape = new { type = "Flow", shape = "MultiDocument" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "Collate", Shape = new { type = "Flow", shape = "Collate" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "SummingJunction", Shape = new { type = "Flow", shape = "SummingJunction" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "Or", Shape = new { type = "Flow", shape = "Or" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "InternalStorage", Shape = new { type = "Flow", shape = "InternalStorage" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "Extract", Shape = new { type = "Flow", shape = "Extract" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "ManualOperation", Shape = new { type = "Flow", shape = "ManualOperation" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "Merge", Shape = new { type = "Flow", shape = "Merge" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "OffPageReference", Shape = new { type = "Flow", shape = "OffPageReference" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "SequentialAccessStorage", Shape = new { type = "Flow", shape = "SequentialAccessStorage" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "Annotation", Shape = new { type = "Flow", shape = "Annotation" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "Annotation2", Shape = new { type = "Flow", shape = "Annotation2" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "data", Shape = new { type = "Flow", shape = "Data" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "Card", Shape = new { type = "Flow", shape = "Card" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "Delay", Shape = new { type = "Flow", shape = "Delay" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "Preparation", Shape = new { type = "Flow", shape = "Preparation" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "Display", Shape = new { type = "Flow", shape = "Display" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "ManualInput", Shape = new { type = "Flow", shape = "ManualInput" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "LoopLimit", Shape = new { type = "Flow", shape = "LoopLimit" }, Style = new { strokeWidth = 2 } });
            SymbolPaletee.Add(new DiagramNode() { Id = "StoredData", Shape = new { type = "Flow", shape = "StoredData" }, Style = new { strokeWidth = 2 } });

            List<DiagramNode> BasicNodes = new List<DiagramNode>();
            BasicNodes.Add(new DiagramNode() { Id = "Rectangle", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Rectangle }, Style = new { strokeWidth = 2 } });
            BasicNodes.Add(new DiagramNode() { Id = "Ellipse", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Ellipse }, Style = new { strokeWidth = 2 } });
            BasicNodes.Add(new DiagramNode() { Id = "Parallelogram", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Parallelogram }, Style = new { strokeWidth = 2 } });
            BasicNodes.Add(new DiagramNode() { Id = "Triangle", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Triangle }, Style = new { strokeWidth = 2 } });
            BasicNodes.Add(new DiagramNode() { Id = "Hexagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Hexagon }, Style = new { strokeWidth = 2 } });
            BasicNodes.Add(new DiagramNode() { Id = "Pentagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Pentagon }, Style = new { strokeWidth = 2 } });
            BasicNodes.Add(new DiagramNode() { Id = "Cylinder", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Cylinder }, Style = new { strokeWidth = 2 } });
            BasicNodes.Add(new DiagramNode() { Id = "Star", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Star }, Style = new { strokeWidth = 2 } });
            BasicNodes.Add(new DiagramNode() { Id = "Plus", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Plus }, Style = new { strokeWidth = 2 } });
            BasicNodes.Add(new DiagramNode() { Id = "Heptagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Heptagon }, Style = new { strokeWidth = 2 } });
            BasicNodes.Add(new DiagramNode() { Id = "Octagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Octagon }, Style = new { strokeWidth = 2 } });
            BasicNodes.Add(new DiagramNode() { Id = "Trapezoid", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Trapezoid }, Style = new { strokeWidth = 2 } });
            BasicNodes.Add(new DiagramNode() { Id = "Decagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Decagon }, Style = new { strokeWidth = 2 } });
            BasicNodes.Add(new DiagramNode() { Id = "RightTriangle", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.RightTriangle }, Style = new { strokeWidth = 2 } });
            BasicNodes.Add(new DiagramNode() { Id = "Diamond", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Diamond }, Style = new { strokeWidth = 2 } });
            ViewBag.BasicShapes = BasicNodes;

            List<DiagramNode> BpmnShapes = new List<DiagramNode>();
            BpmnShapes.Add(new DiagramNode() { Id = "BPMNStart", Shape = new BpmnShapes() { Type = "Bpmn", Shape = "Event", Event = new DiagramBpmnEvent() { Event = BpmnEvents.Start, Trigger = BpmnTriggers.None } }, Style = new { strokeWidth = 2 } });
            BpmnShapes.Add(new DiagramNode() { Id = "Intermediate", Shape = new BpmnShapes() { Type = "Bpmn", Shape = "Event", Event = new DiagramBpmnEvent() { Event = BpmnEvents.Intermediate, Trigger = BpmnTriggers.None } }, Style = new { strokeWidth = 2 } });
            BpmnShapes.Add(new DiagramNode() { Id = "End", Shape = new BpmnShapes() { Type = "Bpmn", Shape = "Event", Event = new DiagramBpmnEvent() { Event = BpmnEvents.End, Trigger = BpmnTriggers.None } }, Style = new { strokeWidth = 2 } });
            BpmnShapes.Add(new DiagramNode() { Id = "Gateway", Shape = new BpmnShapes() { Type = "Bpmn", Shape = "Gateway" }, Style = new { strokeWidth = 2 } });
            BpmnShapes.Add(new DiagramNode() { Id = "Task", Shape = new BpmnShapes() { Type = "Bpmn", Shape = "Activity", Activity = new DiagramBpmnActivity() { Activity = BpmnActivities.Task } }, Style = new { strokeWidth = 2 } });
            BpmnShapes.Add(new DiagramNode()
            {
                Id = "SubProcessEventBased",
                Shape = new BpmnShapes()
                {
                    Type = "Bpmn",
                    Shape = "Activity",
                    Activity = new DiagramBpmnActivity()
                    {
                        Activity = BpmnActivities.SubProcess,
                        SubProcess = new DiagramBpmnSubProcess()
                        {
                            Type = BpmnSubProcessTypes.Transaction,
                            Transaction = new DiagramBpmnTransactionSubProcess()
                            {
                                Cancel = new BpmnTransactionSubProcessCancelTransaction() { Visible = false },
                                Failure = new BpmnTransactionSubProcessFailureTransaction() { Visible = false },
                                Success = new BpmnTransactionSubProcessFailureTransaction() { Visible = false }
                            }
                        }
                    }
                },
                Style = new { strokeWidth = 2 }
            });
            BpmnShapes.Add(new DiagramNode() { Id = "Message", Shape = new BpmnShapes() { Type = "Bpmn", Shape = "Message" }, Style = new { strokeWidth = 2 } });
            BpmnShapes.Add(new DiagramNode() { Id = "DataObject", Shape = new BpmnShapes() { Type = "Bpmn", Shape = "DataObject" }, Style = new { strokeWidth = 2 } });
            BpmnShapes.Add(new DiagramNode() { Id = "DataSource", Shape = new BpmnShapes() { Type = "Bpmn", Shape = "DataSource" }, Style = new { strokeWidth = 2 } });
            BpmnShapes.Add(new DiagramNode() { Id = "Activity", Shape = new BpmnShapes() { Type = "Bpmn", Shape = "Activity" }, Style = new { strokeWidth = 2 } });
            BpmnShapes.Add(new DiagramNode() { Id = "Group", Shape = new BpmnShapes() { Type = "Bpmn", Shape = "Group" }, Style = new { strokeWidth = 2 } });
            ViewBag.nodes = BpmnShapes;

            List<DiagramConnector> connector = new List<DiagramConnector>();
            connector.Add(new DiagramConnector() { Id = "link1", Type = Segments.Orthogonal, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.Arrow, Style = new DiagramShapeStyle() { StrokeWidth = 2 } }, Style = new DiagramStrokeStyle() { StrokeWidth = 2 } });
            connector.Add(new DiagramConnector() { Id = "link2", Type = Segments.Orthogonal, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.Arrow, Style = new DiagramShapeStyle() { StrokeWidth = 2 } }, Style = new DiagramStrokeStyle() { StrokeWidth = 2, StrokeDashArray = "3,3" } });
            connector.Add(new DiagramConnector() { Id = "link3", Type = Segments.Orthogonal, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None }, Style = new DiagramStrokeStyle() { StrokeWidth = 2 } });
            connector.Add(new DiagramConnector() { Id = "link4", Type = Segments.Orthogonal, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None }, Style = new DiagramStrokeStyle() { StrokeWidth = 2, StrokeDashArray = "3,3" } });
            connector.Add(new DiagramConnector() { Id = "link21", Type = Segments.Straight, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.Arrow, Style = new DiagramShapeStyle() { StrokeWidth = 2 } }, Style = new DiagramStrokeStyle() { StrokeWidth = 2 } });
            connector.Add(new DiagramConnector() { Id = "link22", Type = Segments.Straight, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.Arrow, Style = new DiagramShapeStyle() { StrokeWidth = 2 } }, Style = new DiagramStrokeStyle() { StrokeWidth = 2, StrokeDashArray = "3,3" } });
            connector.Add(new DiagramConnector() { Id = "link23", Type = Segments.Straight, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None }, Style = new DiagramStrokeStyle() { StrokeWidth = 2 } });
            connector.Add(new DiagramConnector() { Id = "link24", Type = Segments.Straight, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None }, Style = new DiagramStrokeStyle() { StrokeWidth = 2, StrokeDashArray = "3,3" } });
            connector.Add(new DiagramConnector() { Id = "link33", Type = Segments.Bezier, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None }, Style = new DiagramStrokeStyle() { StrokeWidth = 2 } });
            connector.Add(new DiagramConnector() { Id = "link34", Type = Segments.Bezier, SourcePoint = new DiagramPoint() { X = 0, Y = 0 }, TargetPoint = new DiagramPoint() { X = 40, Y = 40 }, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None }, Style = new DiagramStrokeStyle() { StrokeWidth = 2, StrokeDashArray = "3,3" } });
            ViewBag.Connectors = connector;

            List<SymbolPalettePalette> palettes = new List<SymbolPalettePalette>();
            palettes.Add(new SymbolPalettePalette() { Id = "flow", Expanded = true, Symbols = SymbolPaletee, Title = "Flow Shapes" });
            palettes.Add(new SymbolPalettePalette() { Id = "basic", Expanded = false, Symbols = BasicNodes, Title = "Basic Shapes" });
            palettes.Add(new SymbolPalettePalette() { Id = "bpmn", Expanded = false, Symbols = BpmnShapes, Title = "BPMN Shapes" });
            palettes.Add(new SymbolPalettePalette() { Id = "connectors", Expanded = false, Symbols = connector, Title = "Connectors" });
            ViewBag.palettes = palettes;
            List<contextMenuItems> item = new List<contextMenuItems>();
            item.Add(new contextMenuItems()
            {
                Id = "duplicate",
                Text = "Duplicate",
            });
            ViewBag.item = item;

            List<DiagramCommand> commands = new List<DiagramCommand>();
            commands.Add(new DiagramCommand() { Name = "Duplicate", CanExecute = "canExecute", Execute = "duplicate", Gesture = new DiagramKeyGesture() { Key = Keys.D, KeyModifiers = KeyModifiers.Control } });
            commands.Add(new DiagramCommand() { Name = "SendToBack", CanExecute = "canExecute", Execute = "sendToBack", Gesture = new DiagramKeyGesture() { Key = Keys.B, KeyModifiers = KeyModifiers.Control | KeyModifiers.Shift } });
            commands.Add(new DiagramCommand() { Name = "BringToFront", CanExecute = "canExecute", Execute = "bringToFront", Gesture = new DiagramKeyGesture() { Key = Keys.F, KeyModifiers = KeyModifiers.Control | KeyModifiers.Shift } });
            commands.Add(new DiagramCommand() { Name = "Group", CanExecute = "canExecute", Execute = "group", Gesture = new DiagramKeyGesture() { Key = Keys.G, KeyModifiers = KeyModifiers.Control } });
            commands.Add(new DiagramCommand() { Name = "Ungroup", CanExecute = "canExecute", Execute = "ungroup", Gesture = new DiagramKeyGesture() { Key = Keys.U, KeyModifiers = KeyModifiers.Control } });
            commands.Add(new DiagramCommand() { Name = "cutObjects", CanExecute = "canExecute", Execute = "cutObjects", Gesture = new DiagramKeyGesture() { Key = Keys.X, KeyModifiers = KeyModifiers.Control } });
            commands.Add(new DiagramCommand() { Name = "copyObjects", CanExecute = "canExecute", Execute = "copyObjects", Gesture = new DiagramKeyGesture() { Key = Keys.C, KeyModifiers = KeyModifiers.Control } });
            commands.Add(new DiagramCommand() { Name = "pasteObjects", CanExecute = "canExecute", Execute = "pasteObjects", Gesture = new DiagramKeyGesture() { Key = Keys.V, KeyModifiers = KeyModifiers.Control } });
            commands.Add(new DiagramCommand() { Name = "undo", CanExecute = "canExecute", Execute = "undo", Gesture = new DiagramKeyGesture() { Key = Keys.Z, KeyModifiers = KeyModifiers.Control } });
            commands.Add(new DiagramCommand() { Name = "redo", CanExecute = "canExecute", Execute = "redo", Gesture = new DiagramKeyGesture() { Key = Keys.Y, KeyModifiers = KeyModifiers.Control } });
            commands.Add(new DiagramCommand() { Name = "Delete", CanExecute = "canExecute", Execute = "Delete", Gesture = new DiagramKeyGesture() { Key = Keys.Delete, KeyModifiers = KeyModifiers.Control } });
            commands.Add(new DiagramCommand() { Name = "selectAll", CanExecute = "canExecute", Execute = "selectAll", Gesture = new DiagramKeyGesture() { Key = Keys.A, KeyModifiers = KeyModifiers.Control } });
            ViewBag.commands = commands;

            SymbolPaletteMargin margin = new SymbolPaletteMargin() { Left = 12, Bottom = 12, Right = 12, Top = 12 };
            ViewBag.margin = margin;
            SymbolPaletteSymbolPreview preview = new SymbolPaletteSymbolPreview { Height = 30, Width = 30 };
            ViewBag.preview = preview;

            ViewBag.setPaletteNodeDefaults = "setPaletteNodeDefaults";
            ViewBag.getSymbolInfo = "getSymbolInfo";
            ViewBag.enableSearch = true;
            ViewBag.getNodeDefaults = "getNodeDefaults";
            ViewBag.getConnectorDefaults = "getConnectorDefaults";
            ViewBag.getTool = "CustomTool.prototype.getTool";
            ViewBag.nodechange = "change";

            double[] intervals = { 1, 9, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75 };
            DiagramGridlines grIdLines = new DiagramGridlines()
            { LineColor = "#EEEEEE", LineIntervals = intervals };
            ViewBag.gridLines = grIdLines;
            return View();
        }
        public class ButtonModel
        {
            public string content { get; set; }
            public bool isPrimary { get; set; }
            public string cssClass { get; set; }
        }
        public class contextMenuItems
        {
            [DefaultValue(null)]

            [JsonProperty("text")]
            public string Text
            {
                get;
                set;
            }
            [DefaultValue(null)]

            
            [JsonProperty("id")]
            public string Id
            {
                get;
                set;
            }
        }
        public class BpmnShapes
        {
            [DefaultValue(null)]
            
            [JsonProperty("type")]
            public string Type
            {
                get;
                set;
            }

            [DefaultValue(null)]
            
            [JsonProperty("shape")]
            public string Shape
            {
                get;
                set;
            }
            [DefaultValue(null)]
           
            [JsonProperty("event")]
            public DiagramBpmnEvent Event
            {
                get;
                set;
            }
            [DefaultValue(null)]
            
            [JsonProperty("activity")]
            public DiagramBpmnActivity Activity
            {
                get;
                set;
            }

        }


    }
}