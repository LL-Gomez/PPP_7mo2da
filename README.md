### Sistema de Compras, Ventas y Gestión de Stock

## Descripción
Sistema que centraliza: 
1. Gestión de productos y stock (incluye lotes, vencimientos y scrap);
2. Compras a proveedores (presupuestos, órdenes, remitos, facturación y notas);
3. Ventas a clientes (presupuestos, notas de pedido, facturación, devoluciones y notas);
4. Pagos a proveedores (totales/parciales, formas y diferidos, alertas);
5. Cobranzas a clientes (totales/parciales, formas y diferidos, alertas);
6. Configuración del sistema y reportes exportables.

## Objetivos
1. Automatizar el registro de compras, ventas, pagos, cobranzas y movimientos de stock;
2. Mantener información actualizada (productos, cuentas corrientes, estados de cobranza/pago);
3. Facilitar decisiones con reportes exportables;
4. Ajustar el flujo según modo de operación (Pequeño Negocio / PyME).

## Alcance (Módulos)

# Compras
1. Productos: alta/baja/modificación, consultas, alertas por stock bajo y reportes;
2. Proveedores: alta/baja/modificación, agenda y consultas;
3. Compras: presupuestos, órdenes de compra, consulta de pedidos, remitos, facturas compras, notas de crédito/débito y reportes.

# Ventas
1. Clientes alta/baja/modificación, agenda y consultas;
2. Ventas presupuesto, nota de pedido, notas de crédito/débito y reportes, devoluciones.

# Almacenes (Stock)
1. Ingreso de mercadería por remitos/entrada asociada a órdenes de compra;
2. Reportes de movimientos de stock (entradas/salidas);
3. Gestión de scrap (daños, vencidos, obsoletos, etc.) y reportes asociados.

# Configuración del sistema
1. Selección de modo Pequeño Negocio (flujo reducido) o PyME (flujo completo Presupuesto → Orden → Remito → Factura);
2. Parámetros generales: existencia vs JIT, días de anticipación para alertas de vencimientos, niveles de stock crítico/puntos de reposición, activación de scrap, formatos de numeración e idioma/moneda por defecto; adaptación automática de formularios y reportes según configuración.
3. Pagos (a proveedores): órdenes de pago (alta/baja/modificación), registro de pagos vinculados a facturas y notas (totales o parciales), formas de pago y pagos diferidos, consultas de cuentas corrientes y alertas por vencimientos.
4. Cobranzas (a clientes): recibos de cobranza (alta/baja/modificación), registro de cobranzas vinculadas a facturas y notas (totales o parciales), formas de cobro y cobranzas diferidas, consultas de cuentas corrientes y alertas por vencimientos.

# Requerimientos no funcionales
1. C# (Windows Forms).
2. Arquitectura N Capas.
3. SQL Server.
4. Procedimientos Almacenados.
5. Exportación de reportes a PDF y Excel.
6. Validaciones de campos obligatorios.
7. Integridad entre los módulos de Compras, Ventas, Pagos y Cobranzas.
