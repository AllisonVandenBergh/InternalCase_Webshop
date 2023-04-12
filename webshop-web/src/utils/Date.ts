import { format, parseISO } from 'date-fns'

// Can be changed when this is needed in the frontend!
export const StringToDate = (dateString: string) => {
    return parseISO(dateString);
}

export const DateToString = (date: Date) => {
    return format(date, 'MM/dd/yyyy');
}